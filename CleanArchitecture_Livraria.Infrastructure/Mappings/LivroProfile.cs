using AutoMapper;
using CleanArchitecture_Livraria.Application.UseCases.CadastrarLivro;
using CleanArchitecture_Livraria.Domain.Livros;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_Livraria.Infrastructure.Mappings
{
    public class LivroProfile : Profile
    {
        public LivroProfile()
        {
            CreateMap<Livro, LivroOutput>()
                .ForMember(dest => dest.LivroId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Isbn, opt => opt.MapFrom(src => src.Isbn))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome));
        }
    }
}
