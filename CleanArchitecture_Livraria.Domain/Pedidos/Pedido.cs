using CleanArchitecture_Livraria.Domain.Clientes;
using CleanArchitecture_Livraria.Domain.Livros;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Domain.Pedidos
{
    public class Pedido : Entity
    {
        public List<PedidosLivro> Livros { get; set; }
        public Guid IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime Data { get; set; }

        public Pedido(Cliente cliente)
        {
            this.Livros = new List<PedidosLivro>();
            this.Data = DateTime.Now;
            this.Cliente = cliente;
        }

        private Pedido()
        {
            this.Livros = new List<PedidosLivro>();
            this.Data = DateTime.Now;
        }

        public void AdicionarLivros(Guid livroId)
        {
            var pedidoLivro = new PedidosLivro(this.Id, livroId);

            this.Livros.Add(pedidoLivro);
        }

        public void CalculaValorTotal()
        {
            decimal valorTotal = 0;

            foreach(PedidosLivro p in this.Livros)
            {
                valorTotal += p.Livro.Preco;
            }
        }

    }
}
