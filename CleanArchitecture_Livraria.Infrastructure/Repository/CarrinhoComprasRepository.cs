using CleanArchitecture_Livraria.Application.Repositories;
using CleanArchitecture_Livraria.Domain.CarrinhosCompras;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture_Livraria.Infrastructure.Repository
{
    public class CarrinhoComprasRepository : ICarrinhoWriteOnlyRepository, ICarrinhoReadOnlyRepository
    {
        private readonly Context context;

        public CarrinhoComprasRepository(Context context)
        {
            this.context = context;
        }

        public async Task Add(CarrinhoCompras carrinhoCompras)
        {
            await context.CarrinhoCommpras.AddAsync(carrinhoCompras);
            context.SaveChanges();
        }

        public void Delete(CarrinhoCompras carrinhoCompras)
        {
            context.CarrinhoCommpras.Remove(carrinhoCompras);
            context.SaveChanges();
        }

        public async Task<CarrinhoCompras> Get(Guid id)
        {
            return await context.CarrinhoCommpras.FindAsync(id);
        }

        public void Update(CarrinhoCompras carrinhoCompras)
        {
            context.Entry(carrinhoCompras).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
