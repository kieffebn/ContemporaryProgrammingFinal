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
    public class FavoriteVenueController : ControllerBase
    {

        private readonly ILogger<FavoriteVenueController> _logger;
        private readonly IFavoriteVenueContextDAO _context;

        public FavoriteVenueController(ILogger<FavoriteVenueController> logger, IFavoriteVenueContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetFavoriteVenues());
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var venue = _context.GetFavoriteVenueById(id);
            if (venue == null)
                return NotFound(id);

            return Ok(venue);
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveFavoriteVenueById(id);
            if (result == null)
                return NotFound(id);

            if (result == 0)
                return StatusCode(500, "An error occurred while processing your request");

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(FavoriteVenue name)
        {
            var result = _context.UpdateFavoriteVenue(name);
            if (result == null)
                return NotFound(name.Id);

            if (result == 0)
                return StatusCode(500, "An error occurred while processing your request");

            return Ok();
        }

        [HttpPost]
        public IActionResult Post(FavoriteVenue name)
        {
            var result = _context.Add(name);

            if (result == null)
                return StatusCode(500, "Venue Already Exists");

            if (result == 0)
                return StatusCode(500, "An error occurred while processing your request");

            return Ok();
        }

    }
}
