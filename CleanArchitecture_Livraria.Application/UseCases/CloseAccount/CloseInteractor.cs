namespace CleanArchitecture_Livraria.Application.UseCases.CloseAccount
{
    using System.Threading.Tasks;
    using CleanArchitecture_Livraria.Application.Repositories;
    using CleanArchitecture_Livraria.Domain.Accounts;

    public class CloseInteractor : IInputBoundary<CloseInput>
    {
        private readonly IAccountReadOnlyRepository accountReadOnlyRepository;
        private readonly IAccountWriteOnlyRepository accountWriteOnlyRepository;
        private readonly IOutputBoundary<CloseOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;

        public CloseInteractor(
            IAccountReadOnlyRepository accountReadOnlyRepository,
            IAccountWriteOnlyRepository accountWriteOnlyRepository,
            IOutputBoundary<CloseOutput> outputBoundary,
            IOutputConverter outputConverter)
        {
            this.accountReadOnlyRepository = accountReadOnlyRepository;
            this.accountWriteOnlyRepository = accountWriteOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
        }

        public async Task Process(CloseInput input)
        {
            Account account = await accountReadOnlyRepository.Get(input.AccountId);
			if (account == null)
                throw new AccountNotFoundException($"The account {input.AccountId} does not exists or is already closed.");
			
            account.Close();

            await accountWriteOnlyRepository.Delete(account);

            CloseOutput output = outputConverter.Map<CloseOutput>(account);
            this.outputBoundary.Populate(output);
        }
    }
}