using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data
{
    public class FavoriteVenueContext : DbContext
    {
        public FavoriteVenueContext(DbContextOptions<FavoriteVenueContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FavoriteVenue>().HasData(
                new FavoriteVenue { Id = 1, FavRestaraunt = "Buca Di Beppo", FavBar = "Pins", FavPark = "Ault Park", FavStadium = "Great American Ballpark" },
                new FavoriteVenue { Id = 2, FavRestaraunt = "Gomez", FavBar = "Rosedale", FavPark = "Washington Park", FavStadium = "TQL Stadium" }
            );
        }

        public DbSet<FavoriteVenue> FavoriteVenues { get; set; }
    }
}
