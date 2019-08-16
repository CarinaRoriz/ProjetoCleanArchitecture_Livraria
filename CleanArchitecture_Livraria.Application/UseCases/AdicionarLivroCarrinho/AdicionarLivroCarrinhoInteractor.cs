using CleanArchitecture_Livraria.Application.Repositories;
using CleanArchitecture_Livraria.Domain.Accounts;
using CleanArchitecture_Livraria.Domain.CarrinhosCompras;
using CleanArchitecture_Livraria.Domain.Livros;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture_Livraria.Application.UseCases.AdicionarLivroCarrinho
{
    public class AdicionarLivroCarrinhoInteractor : IInputBoundary<AdicionarLivroCarrinhoInput>
    {
        private readonly ICarrinhoWriteOnlyRepository carrinhoWriteOnlyRepository;
        private readonly ICarrinhoReadOnlyRepository carrinhoReadOnlyRepository;
        private readonly ILivroReadOnlyRepository livroReadOnlyRepository;
        private readonly IOutputBoundary<AdicionarLivroCarrinhoOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;

        public AdicionarLivroCarrinhoInteractor(
            ICarrinhoWriteOnlyRepository carrinhoWriteOnlyRepository,
            ICarrinhoReadOnlyRepository carrinhoReadOnlyRepository,
            ILivroReadOnlyRepository livroReadOnlyRepository, 
            IOutputBoundary<AdicionarLivroCarrinhoOutput> outputBoundary,
            IOutputConverter outputConverter)
        {
            this.carrinhoWriteOnlyRepository = carrinhoWriteOnlyRepository;
            this.carrinhoReadOnlyRepository = carrinhoReadOnlyRepository;
            this.livroReadOnlyRepository = livroReadOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
        }

        public async Task Process(AdicionarLivroCarrinhoInput input)
        {
            CarrinhoCompras carrinhoCompras = await carrinhoReadOnlyRepository.Get(input.CarrinhoId);

            if (carrinhoCompras == null)
                throw new CarrinhoNotFoundException($"O carrinho de compras {input.CarrinhoId} não foi encontrado.");

            Livro livro = await livroReadOnlyRepository.Get(input.LivroId);

            if (livro == null)
                throw new LivroNotFoundException($"O livro {input.CarrinhoId} não foi encontrado.");

            var carrinhoComprasLivro = new CarrinhoComprasLivro(carrinhoCompras.Id, carrinhoCompras, input.LivroId, livro);

            carrinhoCompras.AdicionarLivro(carrinhoComprasLivro);
            
            AdicionarLivroCarrinhoOutput output = outputConverter.Map<AdicionarLivroCarrinhoOutput>(carrinhoComprasLivro);
            this.outputBoundary.Populate(output);

        }
    }
}
