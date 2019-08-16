using CleanArchitecture_Livraria.Domain.Livros;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Domain.CarrinhosCompras
{
    public class CarrinhoCompras : Entity
    {
        public virtual List<CarrinhoComprasLivro> Livros { get; protected set; }


        public CarrinhoCompras()
        {
            this.Livros = new List<CarrinhoComprasLivro>();
        }

        public void AdicionarLivro(CarrinhoComprasLivro livro)
        {
            this.Livros.Add(livro);
        }

        public void RemoverLivro(CarrinhoComprasLivro livro)
        {
            CarrinhoComprasLivro livroEncontrado = this.Livros.Find(l => l.LivroId == livro.LivroId);

            if(livroEncontrado != null)
                this.Livros.Remove(livroEncontrado);
        }
    }
}
