using CleanArchitecture_Livraria.Application.Repositories;
using CleanArchitecture_Livraria.Domain.CarrinhosCompras;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture_Livraria.Application.UseCases.AdicionarCarrinhoCompras
{
    public class AdicionarCarrinhoComprasInteractor : IInputBoundary<AdicionarCarrinhoComprasInput>
    {
        private readonly ICarrinhoWriteOnlyRepository carrinhoWriteOnlyRepository;
        private readonly IOutputBoundary<AdicionarCarrinhoComprasOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;

        public AdicionarCarrinhoComprasInteractor(
            ICarrinhoWriteOnlyRepository carrinhoWriteOnlyRepository,
            IOutputBoundary<AdicionarCarrinhoComprasOutput> outputBoundary,
            IOutputConverter outputConverter)
        {
            this.carrinhoWriteOnlyRepository = carrinhoWriteOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
        }

        public async Task Process(AdicionarCarrinhoComprasInput input)
        {
            CarrinhoCompras carrinhoCompras = new CarrinhoCompras();

            await carrinhoWriteOnlyRepository.Add(carrinhoCompras);

            AdicionarCarrinhoComprasOutput output = outputConverter.Map<AdicionarCarrinhoComprasOutput>(carrinhoCompras);
            this.outputBoundary.Populate(output);

        }
    }
}
