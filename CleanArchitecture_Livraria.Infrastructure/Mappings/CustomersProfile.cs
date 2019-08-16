namespace CleanArchitecture_Livraria.Infrastructure.Mappings
{
    using CleanArchitecture_Livraria.Application.Outputs;
    using CleanArchitecture_Livraria.Domain.Customers;
    using AutoMapper;

    public class CustomersProfile : Profile
    {
        public CustomersProfile()
        {
            CreateMap<Customer, CustomerOutput>()
                    .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Personnummer, opt => opt.MapFrom(src => src.PIN.Text))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name.Text))
                    .ForMember(dest => dest.Accounts, opt => opt.Ignore());
        }
    }
}
