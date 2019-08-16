using CleanArchitecture_Livraria.Domain.Livros;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Infrastructure.Mappings
{
    public class LivroAutorMap : IEntityTypeConfiguration<LivroAutor>
    {
        public void Configure(EntityTypeBuilder<LivroAutor> builder)
        {
            builder.ToTable("LivroAutor");

            builder.HasKey(c => new { c.LivroId, c.AutorId });

            builder.HasOne(bc => bc.Livro)
                .WithMany(b => b.Autores)
                .HasForeignKey(bc => bc.LivroId);

            builder.HasOne(bc => bc.Autor)
                .WithMany(c => c.Livros)
                .HasForeignKey(bc => bc.AutorId);

        }
    }
}
