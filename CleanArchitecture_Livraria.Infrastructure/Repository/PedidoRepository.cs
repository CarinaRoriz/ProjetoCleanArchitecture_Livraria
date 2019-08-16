using CleanArchitecture_Livraria.Application.Repositories;
using CleanArchitecture_Livraria.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture_Livraria.Infrastructure.Repository
{
    public class PedidoRepository : IPedidoWriteOnlyRepository
    {
        private readonly Context context;

        public PedidoRepository(Context context)
        {
            this.context = context;
        }

        public async Task Add(Pedido pedido)
        {
            await context.Pedido.AddAsync(pedido);
            context.SaveChanges();
        }

        public void Delete(Pedido pedido)
        {
            context.Pedido.Remove(pedido);
            context.SaveChanges();
        }

        public void Update(Pedido pedido)
        {
            context.Entry(pedido).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
