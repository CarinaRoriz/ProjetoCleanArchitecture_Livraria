namespace CleanArchitecture_Livraria.Application.Repositories
{
    using CleanArchitecture_Livraria.Domain.Customers;
    using System;
    using System.Threading.Tasks;

    public interface ICustomerReadOnlyRepository
    {
        Task<Customer> Get(Guid id);
    }
}
