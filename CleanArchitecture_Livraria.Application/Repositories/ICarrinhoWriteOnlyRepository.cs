using CleanArchitecture_Livraria.Domain.CarrinhosCompras;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture_Livraria.Application.Repositories
{
    public interface ICarrinhoWriteOnlyRepository
    {
        Task Add(CarrinhoCompras carrinhoCompras);
        void Update(CarrinhoCompras carrinhoCompras);
        void Delete(CarrinhoCompras carrinhoCompras);
    }
}
