using CleanArchitecture_Livraria.Application;
using CleanArchitecture_Livraria.Application.UseCases.AdicionarCarrinhoCompras;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture_Livraria.WebApi.UseCases.AdicionarCarrinhoCompras
{
    [Route("api/[controller]")]
    public class AdicionarCarrinhoComprasController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IInputBoundary<AdicionarCarrinhoComprasInput> adicionarCarrinhoComprasInput;
        private readonly Presenter cadatrarCarrinhoComprasPresenter;

        public AdicionarCarrinhoComprasController(
            IInputBoundary<AdicionarCarrinhoComprasInput> adicionarCarrinhoComprasInput,
            Presenter cadatrarCarrinhoComprasPresenter)
        {
            this.adicionarCarrinhoComprasInput = adicionarCarrinhoComprasInput;
            this.cadatrarCarrinhoComprasPresenter = cadatrarCarrinhoComprasPresenter;
        }

        /// <summary>
        /// Cadastra um carrinho de compras
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CadastraCarrinhoCompras()
        {
            var request = new AdicionarCarrinhoComprasInput();

            await adicionarCarrinhoComprasInput.Process(request);
            return cadatrarCarrinhoComprasPresenter.ViewModel;
        }
    }
}
