using CleanArchitecture_Livraria.Application;
using CleanArchitecture_Livraria.Application.UseCases.EfetivarPedido;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture_Livraria.WebApi.UseCases.EfetivarPedido
{
    [Route("api/[controller]")]
    public class EfetivarPedidoController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IInputBoundary<EfetivarPedidoInput> efetivarPedidoInput;
        private readonly Presenter efetivarPedidoPresenter;
        public EfetivarPedidoController(
            IInputBoundary<EfetivarPedidoInput> efetivarPedidoInput,
            Presenter efetivarPedidoPresenter)
        {
            this.efetivarPedidoInput = efetivarPedidoInput;
            this.efetivarPedidoPresenter = efetivarPedidoPresenter;
        }

        /// <summary>
        /// Efetiva pedido a partir de um carrinho de compras e cliente
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> EfetivarPedido(Guid carrinhoId, ClienteInput cliente)
        {
            var request = new EfetivarPedidoInput(carrinhoId, cliente);

            await efetivarPedidoInput.Process(request);
            return efetivarPedidoPresenter.ViewModel;
        }
    }
}
