using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Application.UseCases.EfetivarPedido
{
    public class EfetivarPedidoInput
    {
        public Guid CarrinhoId { get; set; }

        public ClienteInput Cliente { get; set; }

        public EfetivarPedidoInput(Guid carrinhoId, ClienteInput cliente)
        {
            CarrinhoId = carrinhoId;
            Cliente = cliente;
        }

        public EfetivarPedidoInput()
        {
        }
    }
}
