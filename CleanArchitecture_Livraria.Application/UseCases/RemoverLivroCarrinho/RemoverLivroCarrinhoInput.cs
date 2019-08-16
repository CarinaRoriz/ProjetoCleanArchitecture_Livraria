using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Application.UseCases.RemoverLivroCarrinho
{
    public class RemoverLivroCarrinhoInput
    {
        public Guid CarrinhoId { get; set; }

        public LivroInput Livro { get; set; }

        public RemoverLivroCarrinhoInput(Guid carrinhoId, LivroInput livro)
        {
            CarrinhoId = carrinhoId;
            Livro = livro;
        }

        public RemoverLivroCarrinhoInput()
        {
        }
    }
}
