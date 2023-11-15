using AutoMapper;
using Blog.Application.Features.Entradas.Commands.AgregarEntrada;
using Blog.Application.Features.Entradas.Queries.FiltrarEntradas;
using Blog.Domain;
using System.IO;

namespace Blog.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Entrada, EntradasVM>();
            CreateMap<AgregarEntradaCommand, Entrada>().ReverseMap();
        }
    }
}
