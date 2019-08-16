using CleanArchitecture_Livraria.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture_Livraria.Application.Repositories
{
    public interface IPedidoWriteOnlyRepository
    {
        Task Add(Pedido pedido);
        void Update(Pedido pedido);
        void Delete(Pedido pedido);
    }
}
