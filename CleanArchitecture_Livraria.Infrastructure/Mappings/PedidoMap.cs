using CleanArchitecture_Livraria.Domain.Pedidos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Infrastructure.Mappings
{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.ValorTotal)
              .IsRequired()
              .HasColumnName("ValorTotal");

            builder.Property(c => c.Data)
              .IsRequired()
              .HasColumnName("Data");

            builder.Property(c => c.IdCliente)
              .IsRequired()
              .HasColumnName("IdCliente");

            builder.HasOne(c => c.Cliente)
               .WithMany(c => c.Pedidos)
               .HasForeignKey(x => x.IdCliente)
               .IsRequired(true)
               .OnDelete(DeleteBehavior.SetNull);


        }
    }


}
