using AutoMapper;
using DtoProject.Core.Interfaces;
using DtoProject.Services;

namespace DtoProject.Services
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
        .AddScoped<ISuperHero, SuperHeroServices>();
    }
}