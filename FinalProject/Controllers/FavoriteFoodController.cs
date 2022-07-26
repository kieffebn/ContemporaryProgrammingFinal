using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalProject.Models;
using FinalProject.Data;

namespace FinalProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteFoodController : ControllerBase
    {

        private readonly ILogger<FavoriteFoodController> _logger;
        private readonly FavoriteFoodContext _context;

        public FavoriteFoodController(ILogger<FavoriteFoodController> logger, FavoriteFoodContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.FavoriteMeals.ToList());
        }

    }
}
