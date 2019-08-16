using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Application.UseCases.CadastrarLivro
{
    public class LivroInput
    {
        public string Isbn { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public List<AutorInput> Autores { get; set; }

        public LivroInput(string isbn, string nome, decimal preco)
        {
            Isbn = isbn;
            Nome = nome;
            Preco = preco;
            Autores = new List<AutorInput>();
        }

        public LivroInput()
        {
        }

        public void AdicionarAutor(Guid id)
        {
            var autor = new AutorInput(id);

            this.Autores.Add(autor);
        }
    }
}
