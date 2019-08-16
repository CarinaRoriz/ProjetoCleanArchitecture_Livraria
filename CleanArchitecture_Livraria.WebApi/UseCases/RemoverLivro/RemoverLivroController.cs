using CleanArchitecture_Livraria.Application;
using CleanArchitecture_Livraria.Application.UseCases.RemoverLivroCarrinho;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture_Livraria.WebApi.UseCases.RemoverLivro
{
    [Route("api/[controller]")]
    public class RemoverLivroController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IInputBoundary<RemoverLivroCarrinhoInput> removerLivroCarrinhoInput;
        private readonly Presenter removerLivroCarrinhoPresenter;
        public RemoverLivroController(
            IInputBoundary<RemoverLivroCarrinhoInput> removerLivroCarrinhoInput,
            Presenter removerLivroCarrinhoPresenter)
        {
            this.removerLivroCarrinhoInput = removerLivroCarrinhoInput;
            this.removerLivroCarrinhoPresenter = removerLivroCarrinhoPresenter;
        }

        /// <summary>
        /// Remover livro de um carrinho de compras
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> RemoverLivroCarrinho(Guid carrinhoId, Guid livroId)
        {
            var request = new RemoverLivroCarrinhoInput(carrinhoId, livroId);

            await removerLivroCarrinhoInput.Process(request);
            return removerLivroCarrinhoPresenter.ViewModel;
        }
    }
}
