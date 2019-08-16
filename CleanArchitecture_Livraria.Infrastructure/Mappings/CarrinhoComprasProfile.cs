using AutoMapper;
using CleanArchitecture_Livraria.Application.UseCases.AdicionarCarrinhoCompras;
using CleanArchitecture_Livraria.Domain.CarrinhosCompras;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Infrastructure.Mappings
{
    public class CarrinhoComprasProfile : Profile
    {
        public CarrinhoComprasProfile()
        {
            CreateMap<CarrinhoCompras, AdicionarCarrinhoComprasOutput>()
                .ForMember(dest => dest.CarrinhoComprasId, opt => opt.MapFrom(src => src.Id));
        }
    }
}
