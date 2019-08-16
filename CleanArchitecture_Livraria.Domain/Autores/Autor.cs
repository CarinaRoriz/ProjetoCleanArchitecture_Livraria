using CleanArchitecture_Livraria.Domain.Livros;
using System.Collections.Generic;

namespace CleanArchitecture_Livraria.Domain.Autores
{
    public class Autor : Entity
    {
        public string Nome { get; set; }
        public virtual List<LivroAutor> Livros { get; set; }

        public Autor(string nome)
        {
            Nome = nome;
        }

    }
}