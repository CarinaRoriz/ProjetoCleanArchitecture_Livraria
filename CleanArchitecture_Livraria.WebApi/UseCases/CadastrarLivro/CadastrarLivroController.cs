using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture_Livraria.Application;
using CleanArchitecture_Livraria.Application.UseCases.CadastrarLivro;
using CleanArchitecture_Livraria.WebApi.DTO;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture_Livraria.WebApi.UseCases.CadastrarLivro
{
    [Route("api/[controller]")]
    public class CadastrarLivroController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IInputBoundary<LivroInput> livroInput;
        private readonly Presenter livroPresenter;
        public CadastrarLivroController(
            IInputBoundary<LivroInput> livroInput,
            Presenter livroPresenter)
        {
            this.livroInput = livroInput;
            this.livroPresenter = livroPresenter;
        }

        /// <summary>
        /// Cadastra um livro
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CadastrarLivro(LivroRequest livro)
        {
            var request = new LivroInput(livro.isbn, livro.nome, livro.preco);

            foreach (AutorRequest a in livro.autores)
            {
                request.AdicionarAutor(a.id);
            }

            await livroInput.Process(request);
            return livroPresenter.ViewModel;
        }
    }
}