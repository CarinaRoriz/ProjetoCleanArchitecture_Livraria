using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Application.UseCases.RemoverLivroCarrinho
{
    public class AutorInput
    {
        public AutorInput()
        {
        }

        public AutorInput(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
