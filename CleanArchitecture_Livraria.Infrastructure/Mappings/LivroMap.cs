using CleanArchitecture_Livraria.Domain.Livros;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Infrastructure.Mappings
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Isbn)
              .IsRequired()
              .HasColumnName("Isbn");

            builder.Property(c => c.Nome)
              .IsRequired()
              .HasColumnName("Nome");

            builder.Property(c => c.Preco)
              .IsRequired()
              .HasColumnName("Preco");
            
        }
    }
}
