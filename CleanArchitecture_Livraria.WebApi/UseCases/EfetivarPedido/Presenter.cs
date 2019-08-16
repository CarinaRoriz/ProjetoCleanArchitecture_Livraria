using CleanArchitecture_Livraria.Application;
using CleanArchitecture_Livraria.Application.UseCases.EfetivarPedido;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture_Livraria.WebApi.UseCases.EfetivarPedido
{
    public class Presenter : IOutputBoundary<EfetivarPedidoOutput>
    {
        public IActionResult ViewModel { get; private set; }
        public EfetivarPedidoOutput Output { get; private set; }

        public void Populate(EfetivarPedidoOutput response)
        {
            Output = response;

            if (response == null)
            {
                ViewModel = new NoContentResult();
                return;
            }

            ViewModel = new OkResult();
        }
    }
}
