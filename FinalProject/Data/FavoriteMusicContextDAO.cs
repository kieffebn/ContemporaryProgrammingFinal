using FinalProject.Interfaces;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data
{
    public class FavoriteMusicContextDAO : IFavoriteMusicContextDAO
    {
        private FavoriteMusicContext _context;
        public FavoriteMusicContextDAO(FavoriteMusicContext context)
        {
            _context = context;
        }

        public List<FavoriteMusic> GetFavoriteMusic()
        {
            return _context.FavoriteSongs.ToList();
        }


        public FavoriteMusic GetFavoriteMusicById(int id)
        {
            return _context.FavoriteSongs.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveFavoriteMusicById(int id)
        {
            var songs = this.GetFavoriteMusicById(id);
            if (songs == null) return null;
            try
            {
                _context.FavoriteSongs.Remove(songs);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int? UpdateFavoriteMusic(FavoriteMusic name)
        {
            var musicToUpdate = this.GetFavoriteMusicById(name.Id);
            if (musicToUpdate == null)
                return null;

            musicToUpdate.FavSong1 = name.FavSong1;
            musicToUpdate.FavSong2 = name.FavSong2;
            musicToUpdate.FavSong3 = name.FavSong3;
            musicToUpdate.FavSong4 = name.FavSong4;
            try
            {
                _context.FavoriteSongs.Update(musicToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int? Add(FavoriteMusic name)
        {
            var names = _context.FavoriteSongs.Where(x => x.FavSong1.Equals(name.FavSong1)).FirstOrDefault();

            if (name == null)
                return null;
            try
            {
                _context.FavoriteSongs.Add(name);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}