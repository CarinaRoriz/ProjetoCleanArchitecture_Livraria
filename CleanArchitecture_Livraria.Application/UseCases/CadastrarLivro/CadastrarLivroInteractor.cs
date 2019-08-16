using CleanArchitecture_Livraria.Application.Repositories;
using CleanArchitecture_Livraria.Domain.Livros;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture_Livraria.Application.UseCases.CadastrarLivro
{
    public class CadastrarLivroInteractor : IInputBoundary<LivroInput>
    {
        private readonly ILivroWriteOnlyRepository livroWriteOnlyRepository;
        private readonly IOutputBoundary<LivroOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;

        public CadastrarLivroInteractor(
            ILivroWriteOnlyRepository livroWriteOnlyRepository,
            IOutputBoundary<LivroOutput> outputBoundary,
            IOutputConverter outputConverter)
        {
            this.livroWriteOnlyRepository = livroWriteOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
        }

        public async Task Process(LivroInput input)
        {
            Livro livro = new Livro(input.Isbn, input.Nome, input.Preco);

            foreach(AutorInput autor in input.Autores)
            {
                livro.AdicionarAutor(autor.Nome);
            }

            await livroWriteOnlyRepository.Add(livro);

            LivroOutput output = outputConverter.Map<LivroOutput>(livro);
            this.outputBoundary.Populate(output);
        }
    }
}
