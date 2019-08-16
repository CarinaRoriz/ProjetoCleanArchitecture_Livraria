using CleanArchitecture_Livraria.Domain.Livros;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Domain.Pedidos
{
    public class PedidosLivro : Entity
    {
        public PedidosLivro()
        {
        }

        public PedidosLivro(Guid pedidoId, Guid livroId)
        {
            PedidoId = pedidoId;
            LivroId = livroId;
        }

        public Guid PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
        public Guid LivroId { get; set; }
        public virtual Livro Livro { get; set; }
    }
}
