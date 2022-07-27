using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalProject.Models;
using FinalProject.Data;
using FinalProject.Interfaces;

namespace FinalProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteMusicController : ControllerBase
    {

        private readonly ILogger<FavoriteMusicController> _logger;
        private readonly IFavoriteMusicContextDAO _context;

        public FavoriteMusicController(ILogger<FavoriteMusicController> logger, IFavoriteMusicContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetFavoriteMusic());
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var song = _context.GetFavoriteMusicById(id);
            if (song == null)
                return NotFound(id);

            return Ok(song);
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveFavoriteMusicById(id);
            if (result == null)
                return NotFound(id);

            if (result == 0)
                return StatusCode(500, "An error occurred while processing your request");

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(FavoriteMusic name)
        {
            var result = _context.UpdateFavoriteMusic(name);
            if (result == null)
                return NotFound(name.Id);

            if (result == 0)
                return StatusCode(500, "An error occurred while processing your request");

            return Ok();
        }

        [HttpPost]
        public IActionResult Post(FavoriteMusic name)
        {
            var result = _context.Add(name);

            if (result == null)
                return StatusCode(500, "Song Already Exists");

            if (result == 0)
                return StatusCode(500, "An error occurred while processing your request");

            return Ok();
        }
    }
}