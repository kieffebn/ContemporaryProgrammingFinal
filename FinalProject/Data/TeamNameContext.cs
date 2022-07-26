using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data
{
    public class TeamNameContext : DbContext
    {
        public TeamNameContext(DbContextOptions<TeamNameContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeamName>().HasData(
                new TeamName { Id = 1, PersonName = "Ben Kieffer", Birthday = "06/09/1999", Program = "Software Development", Year = "Senior" },
                new TeamName { Id = 2, PersonName = "Bob Jones", Birthday = "03/12/1999", Program = "Cybersecurity", Year = "Senior" }
            );
        }

        public DbSet<TeamName> TeamNames { get; set; }
    }
}
