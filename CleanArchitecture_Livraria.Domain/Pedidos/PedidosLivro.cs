using CleanArchitecture_Livraria.Domain.Livros;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Domain.Pedidos
{
    public class PedidosLivro : Entity
    {
        private PedidosLivro()
        {
        }

        public PedidosLivro(Pedido pedido, Livro livro)
        {
            PedidoId = pedido.Id;
            Pedido = pedido;
            LivroId = livro.Id;
            Livro = livro;
        }

        public Guid PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
        public Guid LivroId { get; set; }
        public virtual Livro Livro { get; set; }
    }
}
