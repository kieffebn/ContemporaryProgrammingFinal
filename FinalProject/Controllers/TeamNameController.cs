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
    public class TeamNameController : ControllerBase
    {

        private readonly ILogger<TeamNameController> _logger;
        private readonly TeamNameContext _context;

        public TeamNameController(ILogger<TeamNameController> logger, TeamNameContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.TeamNames.ToList());
        }
    }
}