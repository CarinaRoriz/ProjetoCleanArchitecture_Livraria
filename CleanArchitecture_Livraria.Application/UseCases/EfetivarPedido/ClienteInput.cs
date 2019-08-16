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

        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
    }
}
