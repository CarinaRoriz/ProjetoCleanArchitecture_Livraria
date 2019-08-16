using AutoMapper;
using CleanArchitecture_Livraria.Application.UseCases.RemoverLivroCarrinho;
using CleanArchitecture_Livraria.Domain.Livros;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Infrastructure.Mappings
{
    public class RemoverLivroCarrinhoProfile : Profile
    {
        public RemoverLivroCarrinhoProfile()
        {
            CreateMap<Livro, RemoverLivroCarrinhoOutput>()
                .ForMember(dest => dest.LivroId, opt => opt.MapFrom(src => src.Id));
        }
    }
}
