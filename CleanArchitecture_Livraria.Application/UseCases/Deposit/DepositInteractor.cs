﻿namespace CleanArchitecture_Livraria.Application.UseCases.Deposit
{
    using System.Threading.Tasks;
    using CleanArchitecture_Livraria.Application.Repositories;
    using CleanArchitecture_Livraria.Domain.Accounts;
    using CleanArchitecture_Livraria.Application.Outputs;

    public class DepositInteractor : IInputBoundary<DepositInput>
    {
        private readonly IAccountReadOnlyRepository accountReadOnlyRepository;
        private readonly IAccountWriteOnlyRepository accountWriteOnlyRepository;
        private readonly IOutputBoundary<DepositOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;

        public DepositInteractor(
            IAccountReadOnlyRepository accountReadOnlyRepository,
            IAccountWriteOnlyRepository accountWriteOnlyRepository,
            IOutputBoundary<DepositOutput> outputBoundary,
            IOutputConverter outputConverter)
        {
            this.accountReadOnlyRepository = accountReadOnlyRepository;
            this.accountWriteOnlyRepository = accountWriteOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
        }

        public async Task Process(DepositInput input)
        {
            Account account = await accountReadOnlyRepository.Get(input.AccountId);
            if (account == null)
                throw new AccountNotFoundException($"The account {input.AccountId} does not exists or is already closed.");

            Credit credit = new Credit(account.Id, input.Amount);
            account.Deposit(credit);

            await accountWriteOnlyRepository.Update(account, credit);

            TransactionOutput transactionResponse = outputConverter.Map<TransactionOutput>(credit);
            DepositOutput output = new DepositOutput(transactionResponse, account.GetCurrentBalance().Value);

            outputBoundary.Populate(output);
        }
    }
}
