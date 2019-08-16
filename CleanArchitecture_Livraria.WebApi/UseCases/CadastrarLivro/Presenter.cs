namespace CleanArchitecture_Livraria.WebApi.UseCases.CadastrarLivro
{
    using CleanArchitecture_Livraria.Application;
    using CleanArchitecture_Livraria.Application.UseCases.CadastrarLivro;
    using Microsoft.AspNetCore.Mvc;

    public class Presenter : IOutputBoundary<LivroOutput>
    {
        public IActionResult ViewModel { get; private set; }
        public LivroOutput Output { get; private set; }

        public void Populate(LivroOutput response)
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