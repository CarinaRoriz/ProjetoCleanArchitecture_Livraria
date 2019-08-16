namespace CleanArchitecture_Livraria.Application.Repositories
{
    using CleanArchitecture_Livraria.Domain.Customers;
    using System.Threading.Tasks;

    public interface ICustomerWriteOnlyRepository
    {
        Task Add(Customer customer);
        Task Update(Customer customer);
    }
}
