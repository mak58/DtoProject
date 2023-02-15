using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DtoProject.Core.Dtos;
using DtoProject.Core.Interfaces;

namespace DtoProject.Controllers
{
    [Route("[controller]")]
    public class SuperHeroController : ControllerBase    
    {
        private readonly ISuperHero _superHero;

        public SuperHeroController(ISuperHero superHero)
        {
            _superHero = superHero;
        }

        [HttpGet]
        public ActionResult<List<SuperHeroDto>> GetHeroes()
        {
            return Ok(_superHero.GetHeroes());
        }

    }
}