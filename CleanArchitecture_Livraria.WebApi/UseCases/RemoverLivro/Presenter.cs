using CleanArchitecture_Livraria.Application;
using CleanArchitecture_Livraria.Application.UseCases.RemoverLivroCarrinho;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture_Livraria.WebApi.UseCases.RemoverLivro
{
    public class Presenter : IOutputBoundary<RemoverLivroCarrinhoOutput>
    {
        public IActionResult ViewModel { get; private set; }
        public RemoverLivroCarrinhoOutput Output { get; private set; }

        public void Populate(RemoverLivroCarrinhoOutput response)
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
