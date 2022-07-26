using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data
{
    public class FavoriteMusicContext : DbContext
    {
        public FavoriteMusicContext(DbContextOptions<FavoriteMusicContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FavoriteMusic>().HasData(
                new FavoriteMusic { Id = 1, FavSong1 = "Friends - Led Zeppelin", FavSong2 = "Celebration Day - Led Zeppelin", FavSong3 = "Jungle - ELO", FavSong4 = "Tightrope - ELO" },
                new FavoriteMusic { Id = 2, FavSong1 = "Wild West Hero - ELO", FavSong2 = "Running Up That Hill - Kate Bush", FavSong3 = "Master of Puppets - Metallica", FavSong4 = "Every Breath You Take - The Police" }
            );
        }

        public DbSet<FavoriteMusic> FavoriteSongs { get; set; }
    }
}
