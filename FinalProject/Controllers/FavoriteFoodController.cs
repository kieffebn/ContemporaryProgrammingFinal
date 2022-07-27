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
    public class FavoriteFoodController : ControllerBase
    {

        private readonly ILogger<FavoriteFoodController> _logger;
        private readonly IFavoriteFoodContextDAO _context;

        public FavoriteFoodController(ILogger<FavoriteFoodController> logger, IFavoriteFoodContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetFavoriteFoods());
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var food = _context.GetFavoriteFoodById(id);
            if (food == null)
                return NotFound(id);

            return Ok(food);
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveFavoriteFoodById(id);
            if (result == null)
                return NotFound(id);

            if (result == 0)
                return StatusCode(500, "An error occurred while processing your request");

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(FavoriteFood name)
        {
            var result = _context.UpdateFavoriteFood(name);
            if (result == null)
                return NotFound(name.Id);

            if (result == 0)
                return StatusCode(500, "An error occurred while processing your request");

            return Ok();
        }

        [HttpPost]
        public IActionResult Post(FavoriteFood name)
        {
            var result = _context.Add(name);

            if (result == null)
                return StatusCode(500, "Food Already Exists");

            if (result == 0)
                return StatusCode(500, "An error occurred while processing your request");

            return Ok();
        }

    }
}