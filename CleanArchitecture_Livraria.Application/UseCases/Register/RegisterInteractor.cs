namespace CleanArchitecture_Livraria.Application.UseCases.Register
{
    using System.Threading.Tasks;
    using CleanArchitecture_Livraria.Domain.Customers;
    using CleanArchitecture_Livraria.Application.Repositories;
    using CleanArchitecture_Livraria.Domain.Accounts;
    using CleanArchitecture_Livraria.Application.Outputs;

    public class RegisterInteractor : IInputBoundary<RegisterInput>
    {
        private readonly ICustomerWriteOnlyRepository customerWriteOnlyRepository;
        private readonly IAccountWriteOnlyRepository accountWriteOnlyRepository;
        private readonly IOutputBoundary<RegisterOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;
        
        public RegisterInteractor(
            ICustomerWriteOnlyRepository customerWriteOnlyRepository,
            IAccountWriteOnlyRepository accountWriteOnlyRepository,
            IOutputBoundary<RegisterOutput> outputBoundary,
            IOutputConverter outputConverter)
        {
            this.customerWriteOnlyRepository = customerWriteOnlyRepository;
            this.accountWriteOnlyRepository = accountWriteOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
        }

        public async Task Process(RegisterInput input)
        {
            Customer customer = new Customer(input.PIN, input.Name);

            Account account = new Account(customer.Id);
            Credit credit = new Credit(account.Id, input.InitialAmount);
            account.Deposit(credit);

            customer.Register(account.Id);

            await customerWriteOnlyRepository.Add(customer);
            await accountWriteOnlyRepository.Add(account, credit);

            CustomerOutput customerOutput = outputConverter.Map<CustomerOutput>(customer);
            AccountOutput accountOutput = outputConverter.Map<AccountOutput>(account);
            RegisterOutput output = new RegisterOutput(customerOutput, accountOutput);

            outputBoundary.Populate(output);
        }
    }
}
