using CleanArchitecture_Livraria.Domain.CarrinhosCompras;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Infrastructure.Mappings
{
    public class CarrinhoComprasLivroMap : IEntityTypeConfiguration<CarrinhoComprasLivro>
    {
        public void Configure(EntityTypeBuilder<CarrinhoComprasLivro> builder)
        {
            builder.ToTable("CarrinhoComprasLivro");

            builder.HasKey(c => new { c.CarrinhoComprasId, c.LivroId });

            builder.HasOne(bc => bc.CarrinhoCompras)
                .WithMany(b => b.Livros)
                .HasForeignKey(bc => bc.CarrinhoComprasId);

            builder.HasOne(bc => bc.Livro)
                .WithMany(c => c.CarrinhoCompras)
                .HasForeignKey(bc => bc.LivroId);

        }
    }
}
