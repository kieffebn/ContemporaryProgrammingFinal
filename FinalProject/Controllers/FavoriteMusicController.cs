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
    public class FavoriteMusicController : ControllerBase
    {

        private readonly ILogger<FavoriteMusicController> _logger;
        private readonly FavoriteMusicContext _context;

        public FavoriteMusicController(ILogger<FavoriteMusicController> logger, FavoriteMusicContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.FavoriteSongs.ToList());
        }
    }
}
