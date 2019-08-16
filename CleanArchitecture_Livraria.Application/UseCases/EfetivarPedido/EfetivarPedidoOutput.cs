using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Application.UseCases.EfetivarPedido
{
    public class EfetivarPedidoOutput
    {
        public EfetivarPedidoOutput()
        {
        }

        public EfetivarPedidoOutput(Guid pedidoId)
        {
            PedidoId = pedidoId;
        }

        public Guid PedidoId { get; set; }
    }
}
