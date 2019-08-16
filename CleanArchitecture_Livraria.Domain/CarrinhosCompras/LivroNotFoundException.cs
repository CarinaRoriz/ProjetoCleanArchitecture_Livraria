using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Domain.CarrinhosCompras
{
    public class LivroNotFoundException : DomainException
    {
        public LivroNotFoundException(string message)
            : base(message)
        { }
    }
}
