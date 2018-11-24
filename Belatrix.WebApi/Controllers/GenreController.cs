using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Belatrix.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Belatrix.WebApi.Controllers
{
    [Route("api/genre")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IUnitofWork _unit; 

        public GenreController(IUnitofWork unit)
        {
            _unit = unit;
        }
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_unit.Genres.GetById(id));
        }
    }
}