using AutoMapper;
using DtoProject.Core.Models;
using DtoProject.Core.Dtos;

namespace DtoProject.Core.AutoMappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SuperHero, SuperHeroDto>()
              .ReverseMap();
        }
    }
}