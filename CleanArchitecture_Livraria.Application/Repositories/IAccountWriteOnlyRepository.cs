﻿namespace CleanArchitecture_Livraria.Application.Repositories
{
    using CleanArchitecture_Livraria.Domain.Accounts;
    using System.Threading.Tasks;

    public interface IAccountWriteOnlyRepository
    {
        Task Add(Account account, Credit credit);
        Task Update(Account account, Transaction transaction);
        Task Delete(Account account);
    }
}
