using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Belatrix.Models;
using Belatrix.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Belatrix.WebApi.Controllers
{
    [Route("api/playlist")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        private readonly IUnitofWork _unit;

        public PlaylistController(IUnitofWork unit)
        {
            _unit = unit;
        }
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_unit.Playlist.GetById(id));

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_unit.Playlist.GetList());
        }
        
        [HttpDelete]
        public IActionResult Delete(Playlist playlist)
        {
            return Ok(_unit.Playlist.Delete(playlist));
        }

        [HttpPut]
        public IActionResult Update(Playlist playlist)
        {
            return Ok(_unit.Playlist.Update(playlist));
        }

    }
}