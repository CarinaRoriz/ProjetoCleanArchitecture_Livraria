using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Application.UseCases.CadastrarLivro
{
    public class LivroOutput
    {
        public LivroOutput(Guid livroId, string isbn, string nome)
        {
            LivroId = livroId;
            Isbn = isbn;
            Nome = nome;
        }

        public LivroOutput()
        {
        }

        public Guid LivroId { get; set; }
        public string Isbn { get; set; }
        public string Nome { get; set; }

    }
}
