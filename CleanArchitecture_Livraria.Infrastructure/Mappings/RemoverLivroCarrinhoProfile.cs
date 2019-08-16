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
                .ForMember(dest => dest.Livro.Isbn, opt => opt.MapFrom(src => src.Isbn))
                .ForMember(dest => dest.Livro.Nome, opt => opt.MapFrom(src => src.Nome));
        }
    }
}
