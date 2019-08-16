using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Application.UseCases.AdicionarCarrinhoCompras
{
    public class AdicionarCarrinhoComprasOutput
    {
        public AdicionarCarrinhoComprasOutput()
        {
        }

        public AdicionarCarrinhoComprasOutput(Guid carrinhoComprasId)
        {
            CarrinhoComprasId = carrinhoComprasId;
        }

        public Guid CarrinhoComprasId { get; set; }
    }
}
