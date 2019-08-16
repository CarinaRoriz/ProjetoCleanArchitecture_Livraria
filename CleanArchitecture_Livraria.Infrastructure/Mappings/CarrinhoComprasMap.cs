using CleanArchitecture_Livraria.Domain.CarrinhosCompras;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Infrastructure.Mappings
{
    public class CarrinhoComprasMap : IEntityTypeConfiguration<CarrinhoCompras>
    {
        public void Configure(EntityTypeBuilder<CarrinhoCompras> builder)
        {
            builder.ToTable("CarrinhoCompras");

            builder.HasKey(c => c.Id);

            builder.HasMany(c => c.Livros)
            .WithOne(c => c.CarrinhoCompras)
            .HasForeignKey(x => x.LivroId);

        }
    }
}
