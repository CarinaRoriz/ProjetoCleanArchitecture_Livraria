using CleanArchitecture_Livraria.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Domain.Clientes
{
    public class Cliente : Entity
    {
        public virtual string Nome { get; protected set; }
        public virtual string CPF { get; protected set; }
        public virtual string Email { get; protected set; }
        public virtual List<Pedido> Pedidos { get; set; }

        public Cliente(string nome, string cPF, string email)
        {
            Nome = nome;
            CPF = cPF;
            Email = email;
        }
    }
}
