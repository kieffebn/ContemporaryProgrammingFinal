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
    public class FavoriteVenueController : ControllerBase
    {

        private readonly ILogger<FavoriteVenueController> _logger;
        private readonly FavoriteVenueContext _context;

        public FavoriteVenueController(ILogger<FavoriteVenueController> logger, FavoriteVenueContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.FavoriteVenues.ToList());
        }

    }
}
