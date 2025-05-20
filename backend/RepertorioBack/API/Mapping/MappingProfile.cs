using AutoMapper;
using RepertorioBack.Aplication.Dtos;
using RepertorioBack.Domain.Models;

namespace RepertorioBack.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MusicaAgregate, MusicaDto>().ReverseMap();
        }
    }
}
