using CleanArchitecture_Livraria.Application;
using CleanArchitecture_Livraria.Application.UseCases.AdicionarLivroCarrinho;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture_Livraria.WebApi.UseCases.AdicionarLivro
{
    public class Presenter : IOutputBoundary<AdicionarLivroCarrinhoOutput>
    {
        public IActionResult ViewModel { get; private set; }
        public AdicionarLivroCarrinhoOutput Output { get; private set; }

        public void Populate(AdicionarLivroCarrinhoOutput response)
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
