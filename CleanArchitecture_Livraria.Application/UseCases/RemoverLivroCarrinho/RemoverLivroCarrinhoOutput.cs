using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Application.UseCases.RemoverLivroCarrinho
{
    public class RemoverLivroCarrinhoOutput
    {
        public Guid LivroId;

        public RemoverLivroCarrinhoOutput()
        {
        }

        public RemoverLivroCarrinhoOutput(Guid livroId)
        {
            LivroId = livroId;
        }
    }
}
