using CleanArchitecture_Livraria.Domain.Clientes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Infrastructure.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
              .IsRequired()
              .HasColumnName("Nome");

            builder.Property(c => c.CPF)
              .IsRequired()
              .HasColumnName("Cpf");

            builder.Property(c => c.Email)
              .IsRequired()
              .HasColumnName("Email");

            builder.HasMany(c => c.Pedidos)
                .WithOne(c => c.Cliente)
                .HasForeignKey(x => x.Id);

        }
    }
}
