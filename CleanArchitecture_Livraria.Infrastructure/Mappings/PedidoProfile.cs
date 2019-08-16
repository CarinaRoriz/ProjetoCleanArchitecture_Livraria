using AutoMapper;
using CleanArchitecture_Livraria.Application.UseCases.EfetivarPedido;
using CleanArchitecture_Livraria.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Infrastructure.Mappings
{
    public class PedidoProfile : Profile
    {
        public PedidoProfile()
        {
            CreateMap<Pedido, EfetivarPedidoOutput>()
                .ForMember(dest => dest.PedidoId, opt => opt.MapFrom(src => src.Id));
        }
    }
}
