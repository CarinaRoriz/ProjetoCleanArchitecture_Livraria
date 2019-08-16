using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture_Livraria.WebApi.DTO
{
    public class LivroRequest
    {
        public string isbn { get; set; }
        public string nome { get; set; }
        public decimal preco { get; set; }
        public List<AutorRequest> autores { get; set; }
    }
}
