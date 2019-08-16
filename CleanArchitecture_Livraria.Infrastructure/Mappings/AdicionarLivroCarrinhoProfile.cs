using AutoMapper;
using CleanArchitecture_Livraria.Application.UseCases.AdicionarLivroCarrinho;
using CleanArchitecture_Livraria.Domain.Livros;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Infrastructure.Mappings
{
    public class AdicionarLivroCarrinhoProfile : Profile
    {
        public AdicionarLivroCarrinhoProfile()
        {
            CreateMap<Livro, AdicionarLivroCarrinhoOutput>()
                .ForMember(dest => dest.Livro.Isbn, opt => opt.MapFrom(src => src.Isbn))
                .ForMember(dest => dest.Livro.Nome, opt => opt.MapFrom(src => src.Nome));
        }
    }
}
