using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Application.UseCases.EfetivarPedido
{
    public class ClienteInput
    {
        public ClienteInput()
        {
        }

        public ClienteInput(string nome, string cPF, string email)
        {
            Nome = nome;
            CPF = cPF;
            Email = email;
        }

        public virtual string Nome { get; set; }
        public virtual string CPF { get; set; }
        public virtual string Email { get; set; }
    }
}
