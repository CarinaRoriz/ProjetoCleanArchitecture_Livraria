using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Application.UseCases.RemoverLivroCarrinho
{
    public class RemoverLivroCarrinhoOutput
    {
        public LivroOutput Livro;

        public RemoverLivroCarrinhoOutput()
        {
        }

        public RemoverLivroCarrinhoOutput(LivroOutput livro)
        {
            Livro = livro;
        }
    }
}
