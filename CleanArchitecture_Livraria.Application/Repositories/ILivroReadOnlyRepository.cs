using CleanArchitecture_Livraria.Domain.Livros;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture_Livraria.Application.Repositories
{
    public interface ILivroReadOnlyRepository
    {
        Task<Livro> Get(Guid id);
    }
}
