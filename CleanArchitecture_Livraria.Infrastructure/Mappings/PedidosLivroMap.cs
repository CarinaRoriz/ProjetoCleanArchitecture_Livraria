using CleanArchitecture_Livraria.Domain.Pedidos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Infrastructure.Mappings
{
    public class PedidosLivroMap : IEntityTypeConfiguration<PedidosLivro>
    {
        public void Configure(EntityTypeBuilder<PedidosLivro> builder)
        {
            builder.ToTable("PedidosLivro");

            builder.HasKey(c => new { c.PedidoId, c.LivroId });

            builder.HasOne(bc => bc.Pedido)
                .WithMany(b => b.Livros)
                .HasForeignKey(bc => bc.PedidoId);

            builder.HasOne(bc => bc.Livro)
                .WithMany(c => c.Pedidos)
                .HasForeignKey(bc => bc.LivroId);

        }
    }
}
