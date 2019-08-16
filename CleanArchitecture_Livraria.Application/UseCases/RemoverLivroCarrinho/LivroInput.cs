using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Application.UseCases.RemoverLivroCarrinho
{
    public class LivroInput
    {
        public LivroInput()
        {
        }

        public LivroInput(string isbn, string nome, decimal preco, List<AutorInput> autores)
        {
            Isbn = isbn;
            Nome = nome;
            Preco = preco;
            Autores = autores;
        }

        public string Isbn { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public List<AutorInput> Autores { get; set; }
    }
}
