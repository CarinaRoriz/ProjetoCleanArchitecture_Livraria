using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Application.UseCases.RemoverLivroCarrinho
{
    public class RemoverLivroCarrinhoInput
    {
        public Guid CarrinhoId { get; set; }

        public Guid LivroId { get; set; }

        public RemoverLivroCarrinhoInput(Guid carrinhoId, Guid livroId)
        {
            CarrinhoId = carrinhoId;
            LivroId = livroId;
        }

        public RemoverLivroCarrinhoInput()
        {
        }
    }
}
