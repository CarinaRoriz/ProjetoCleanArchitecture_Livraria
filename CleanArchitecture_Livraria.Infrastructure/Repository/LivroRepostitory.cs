using CleanArchitecture_Livraria.Application.Repositories;
using CleanArchitecture_Livraria.Domain.Livros;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture_Livraria.Infrastructure.Repository
{
    public class LivroRepostitory : ILivroWriteOnlyRepository
    {
        private readonly Context context;

        public LivroRepostitory(Context context)
        {
            this.context = context;
        }

        public async Task Add(Livro livro)
        {
            await context.Livro.AddAsync(livro);
            context.SaveChanges();
        }

        public void Delete(Livro livro)
        {
            context.Livro.Remove(livro);
            context.SaveChanges();
        }

        public void Update(Livro livro)
        {
            context.Entry(livro).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
