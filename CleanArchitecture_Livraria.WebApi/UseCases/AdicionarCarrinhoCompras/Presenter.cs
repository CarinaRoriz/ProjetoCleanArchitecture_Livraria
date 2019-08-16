using CleanArchitecture_Livraria.Application;
using CleanArchitecture_Livraria.Application.UseCases.AdicionarCarrinhoCompras;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture_Livraria.WebApi.UseCases.AdicionarCarrinhoCompras
{
    public class Presenter : IOutputBoundary<AdicionarCarrinhoComprasOutput>
    {
        public IActionResult ViewModel { get; private set; }
        public AdicionarCarrinhoComprasOutput Output { get; private set; }

        public void Populate(AdicionarCarrinhoComprasOutput response)
        {
            Output = response;

            if (response == null)
            {
                ViewModel = new NoContentResult();
                return;
            }

            ViewModel = new ObjectResult(response.CarrinhoComprasId);
        }
    }
}
