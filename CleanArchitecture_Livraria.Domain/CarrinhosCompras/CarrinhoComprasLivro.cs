using CleanArchitecture_Livraria.Domain.Livros;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Domain.CarrinhosCompras
{
    public class CarrinhoComprasLivro : Entity
    {
        public CarrinhoComprasLivro(Guid carrinhoComprasId, Guid livroId)
        {
            CarrinhoComprasId = carrinhoComprasId;
            LivroId = livroId;
        }

        public Guid CarrinhoComprasId { get; set; }
        public virtual CarrinhoCompras CarrinhoCompras { get; set; }
        public Guid LivroId { get; set; }
        public virtual Livro Livro { get; set; }
    }
}
