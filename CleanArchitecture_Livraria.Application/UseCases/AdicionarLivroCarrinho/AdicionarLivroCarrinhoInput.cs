using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Application.UseCases.AdicionarLivroCarrinho
{
    public class AdicionarLivroCarrinhoInput
    {
        public Guid CarrinhoId { get; set; }

        public Guid LivroId { get; set; }

        public AdicionarLivroCarrinhoInput(Guid carrinhoId, Guid livroId)
        {
            CarrinhoId = carrinhoId;
            LivroId = livroId;
        }
    }
}
