using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Application.UseCases.CadastrarLivro
{
    public class AutorInput
    {
        public Guid Id { get; set; }

        public AutorInput(Guid id)
        {
            Id = id;
        }

        public AutorInput()
        {
        }
    }
}
