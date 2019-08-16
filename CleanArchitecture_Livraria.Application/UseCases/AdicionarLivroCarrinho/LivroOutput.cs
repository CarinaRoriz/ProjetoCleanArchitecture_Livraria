using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Application.UseCases.AdicionarLivroCarrinho
{
    public class LivroOutput
    {
        public LivroOutput()
        {
        }

        public LivroOutput(string isbn, string nome)
        {
            Isbn = isbn;
            Nome = nome;
        }

        public string Isbn { get; set; }
        public string Nome { get; set; }

    }
}
