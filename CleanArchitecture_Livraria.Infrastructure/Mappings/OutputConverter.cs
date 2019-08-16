namespace CleanArchitecture_Livraria.Infrastructure.Mappings
{
    using CleanArchitecture_Livraria.Application;
    using AutoMapper;

    public class OutputConverter : IOutputConverter
    {
        private readonly IMapper mapper;

        public OutputConverter()
        {
            mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<LivroProfile>();
                cfg.AddProfile<PedidoProfile>();
                cfg.AddProfile<CarrinhoComprasProfile>();
            }).CreateMapper();
        }

        public T Map<T>(object source)
        {
            T model = mapper.Map<T>(source);
            return model;
        }
    }
}
