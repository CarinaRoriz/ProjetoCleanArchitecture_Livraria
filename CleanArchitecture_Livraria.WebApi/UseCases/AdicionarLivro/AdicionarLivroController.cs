using CleanArchitecture_Livraria.Application;
using CleanArchitecture_Livraria.Application.UseCases.AdicionarLivroCarrinho;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture_Livraria.WebApi.UseCases.AdicionarLivro
{
    [Route("api/[controller]")]
    public class AdicionarLivroController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IInputBoundary<AdicionarLivroCarrinhoInput> adicionarLivroCarrinhoInput;
        private readonly Presenter adicionarLivroCarrinhoPresenter;
        public AdicionarLivroController(
            IInputBoundary<AdicionarLivroCarrinhoInput> adicionarLivroCarrinhoInput,
            Presenter adicionarLivroCarrinhoPresenter)
        {
            this.adicionarLivroCarrinhoInput = adicionarLivroCarrinhoInput;
            this.adicionarLivroCarrinhoPresenter = adicionarLivroCarrinhoPresenter;
        }

        /// <summary>
        /// Adicionar livro à um carrinho de compras
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> AdicionarLivroCarrinho(Guid carrinhoId, Guid livroId)
        {
            var request = new AdicionarLivroCarrinhoInput(carrinhoId, livroId);

            await adicionarLivroCarrinhoInput.Process(request);
            return adicionarLivroCarrinhoPresenter.ViewModel;
        }
    }
}
