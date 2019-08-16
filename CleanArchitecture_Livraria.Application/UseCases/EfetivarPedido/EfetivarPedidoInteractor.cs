using CleanArchitecture_Livraria.Application.Repositories;
using CleanArchitecture_Livraria.Domain.Accounts;
using CleanArchitecture_Livraria.Domain.CarrinhosCompras;
using CleanArchitecture_Livraria.Domain.Clientes;
using CleanArchitecture_Livraria.Domain.Livros;
using CleanArchitecture_Livraria.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture_Livraria.Application.UseCases.EfetivarPedido
{
    public class EfetivarPedidoInteractor : IInputBoundary<EfetivarPedidoInput>
    {
        private readonly IPedidoWriteOnlyRepository efetivarPedidoWriteOnlyRepository;
        private readonly ILivroReadOnlyRepository livroReadOnlyRepository;
        private readonly IOutputBoundary<EfetivarPedidoOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;
        private readonly ICarrinhoReadOnlyRepository carrinhoReadOnlyRepository;

        public EfetivarPedidoInteractor(
            IPedidoWriteOnlyRepository efetivarPedidoWriteOnlyRepository,
            ILivroReadOnlyRepository livroReadOnlyRepository,
            IOutputBoundary<EfetivarPedidoOutput> outputBoundary,
            IOutputConverter outputConverter,
            ICarrinhoReadOnlyRepository carrinhoReadOnlyRepository)
        {
            this.efetivarPedidoWriteOnlyRepository = efetivarPedidoWriteOnlyRepository;
            this.livroReadOnlyRepository = livroReadOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
            this.carrinhoReadOnlyRepository = carrinhoReadOnlyRepository;
        }

        public async Task Process(EfetivarPedidoInput input)
        {
            CarrinhoCompras carrinhoCompras = await carrinhoReadOnlyRepository.Get(input.CarrinhoId);

            if (carrinhoCompras == null)
                throw new CarrinhoNotFoundException($"O carrinho de compras {input.CarrinhoId} não foi encontrado.");

            Cliente cliente = new Cliente(input.Cliente.Nome, input.Cliente.CPF, input.Cliente.Email);

            Pedido pedido = new Pedido(cliente);

            foreach(CarrinhoComprasLivro c in carrinhoCompras.Livros)
            {
                Livro livro = await livroReadOnlyRepository.Get(c.LivroId);
                pedido.AdicionarLivros(livro);
            }
            
            pedido.CalculaValorTotal();

            EfetivarPedidoOutput output = outputConverter.Map<EfetivarPedidoOutput>(pedido);
            this.outputBoundary.Populate(output);
        }
    }
}
