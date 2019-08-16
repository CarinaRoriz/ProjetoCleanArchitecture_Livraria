using CleanArchitecture_Livraria.Domain.Autores;
using CleanArchitecture_Livraria.Domain.CarrinhosCompras;
using CleanArchitecture_Livraria.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Domain.Livros
{
    public class Livro : Entity
    {
        public string Isbn { get; protected set; }
        public string Nome { get; protected set; }
        public decimal Preco { get; protected set; }
        public virtual List<LivroAutor> Autores { get; protected set; }

        public virtual List<CarrinhoComprasLivro> CarrinhoCompras { get; set; }

        public virtual List<PedidosLivro> Pedidos { get; set; }

        public Livro()
        {
            Autores = new List<LivroAutor>();
        }

        public Livro(string isbn, string nome, decimal preco)
        {
            this.Isbn = isbn;
            this.Nome = nome;
            this.Preco = preco;

            Autores = new List<LivroAutor>();
        }

        public void AdicionarAutor(Guid autorId)
        {
            var autor = new LivroAutor(this.Id, autorId);

            this.Autores.Add(autor);
        }

    }
}
