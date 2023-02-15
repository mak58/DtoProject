using AutoMapper;
using DtoProject.Core.Dtos;
using DtoProject.Core.Interfaces;
using DtoProject.Core.Models;


namespace DtoProject.Services
{
    public class SuperHeroServices: ISuperHero
    {
        private readonly IMapper _mapper;

        public SuperHeroServices(IMapper mapper)
        {
            _mapper = mapper;             
        }

        public List<SuperHeroDto> GetHeroes()
        {
            var heroes = new List<SuperHero>
            {
                new SuperHero {
                    
                    Id = 1,
                    Name = "SpiderMan",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York",
                    DateAdded = new DateTime(2023, 01, 01),
                    DateModified = new DateTime(2023, 02, 10)
                },

                new SuperHero {

                    Id = 2,
                    Name = "Tony Stark",
                    FirstName = "Tony",
                    LastName = "Stark",
                    Place = "Malibu",
                    DateAdded = new DateTime(2023, 01, 15),
                    DateModified = new DateTime(2023, 02, 12)
                }
            };

            return 
              _mapper.Map<List<SuperHeroDto>>(heroes);
        }
  
        
    }
}