using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data
{
    public class FavoriteFoodContext : DbContext
    {
        public FavoriteFoodContext(DbContextOptions<FavoriteFoodContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FavoriteFood>().HasData(
                new FavoriteFood { Id = 1, FavBreak = "French Toast", FavLunch = "Pizza", FavDin = "Pad Thai", FavDes = "Cheesecake" },
                new FavoriteFood { Id = 2, FavBreak = "Pancakes", FavLunch = "Subs", FavDin = "Spaghetti", FavDes = "Brownies" }
            );
        }

        public DbSet<FavoriteFood> FavoriteMeals { get; set; }
    }
}
