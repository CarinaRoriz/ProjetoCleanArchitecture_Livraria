namespace CleanArchitecture_Livraria.Application.Repositories
{
    using CleanArchitecture_Livraria.Domain.Accounts;
    using System;
    using System.Threading.Tasks;

    public interface IAccountReadOnlyRepository
    {
        Task<Account> Get(Guid id);        
    }
}
