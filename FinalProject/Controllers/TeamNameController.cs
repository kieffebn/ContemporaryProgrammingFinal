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
    public class TeamNameController : ControllerBase
    {

        private readonly ILogger<TeamNameController> _logger;
        private readonly ITeamNameContextDAO _context;

        public TeamNameController(ILogger<TeamNameController> logger, ITeamNameContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetTeamNames());
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var name = _context.GetTeamNameById(id);
            if (name == null)
                return NotFound(id);

            return Ok(name);
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveTeamNameById(id);
            if (result == null)
                return NotFound(id);

            if (result == 0)
                return StatusCode(500, "An error occurred while processing your request");

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(TeamName name)
        {
            var result = _context.UpdateTeamName(name);
            if (result == null)
                return NotFound(name.Id);

            if (result == 0)
                return StatusCode(500, "An error occurred while processing your request");

            return Ok();
        }

        [HttpPost]
        public IActionResult Post(TeamName name)
        {
            var result = _context.Add(name);

            if (result == null)
                return StatusCode(500, "Name Already Exists");

            if (result == 0)
                return StatusCode(500, "An error occurred while processing your request");

            return Ok();
        }
    }
}