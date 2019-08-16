using CleanArchitecture_Livraria.Application.Repositories;
using CleanArchitecture_Livraria.Domain.Accounts;
using CleanArchitecture_Livraria.Domain.CarrinhosCompras;
using CleanArchitecture_Livraria.Domain.Livros;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture_Livraria.Application.UseCases.RemoverLivroCarrinho
{
    public class RemoverLivroCarrinhoInteractor : IInputBoundary<RemoverLivroCarrinhoInput>
    {
        private readonly ICarrinhoWriteOnlyRepository carrinhoWriteOnlyRepository;
        private readonly ICarrinhoReadOnlyRepository carrinhoReadOnlyRepository;
        private readonly IOutputBoundary<RemoverLivroCarrinhoOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;

        public RemoverLivroCarrinhoInteractor(
            ICarrinhoWriteOnlyRepository carrinhoWriteOnlyRepository,
            ICarrinhoReadOnlyRepository carrinhoReadOnlyRepository,
            IOutputBoundary<RemoverLivroCarrinhoOutput> outputBoundary,
            IOutputConverter outputConverter)
        {
            this.carrinhoWriteOnlyRepository = carrinhoWriteOnlyRepository;
            this.carrinhoReadOnlyRepository = carrinhoReadOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
        }

        public async Task Process(RemoverLivroCarrinhoInput input)
        {
            CarrinhoCompras carrinhoCompras = await carrinhoReadOnlyRepository.Get(input.CarrinhoId);

            if (carrinhoCompras == null)
                throw new CarrinhoNotFoundException($"O carrinho de compras {input.CarrinhoId} não foi encontrado.");

            var carrinhoComprasLivro = new CarrinhoComprasLivro(input.CarrinhoId, input.LivroId);

            carrinhoCompras.RemoverLivro(carrinhoComprasLivro);

            RemoverLivroCarrinhoOutput output = outputConverter.Map<RemoverLivroCarrinhoOutput>(carrinhoComprasLivro);
            this.outputBoundary.Populate(output);
        }
    }
}
