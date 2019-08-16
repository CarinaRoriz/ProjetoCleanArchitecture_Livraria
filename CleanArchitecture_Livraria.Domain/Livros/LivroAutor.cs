using CleanArchitecture_Livraria.Domain.Autores;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Domain.Livros
{
    public class LivroAutor : Entity
    {
        public LivroAutor()
        {
        }

        public LivroAutor(Guid livroId, Livro livro, Guid autorId, Autor autor)
        {
            LivroId = livroId;
            Livro = livro;
            AutorId = autorId;
            Autor = autor;
        }

        public LivroAutor(Guid livroId, Guid autorId)
        {
            LivroId = livroId;
            AutorId = autorId;
        }

        public Guid LivroId { get; set; }
        public virtual Livro Livro { get; set; }
        public Guid AutorId { get; set; }
        public virtual Autor Autor { get; set; }
    }
}
