using FinalProject.Interfaces;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data
{
    public class FavoriteFoodContextDAO : IFavoriteFoodContextDAO
    {
        private FavoriteFoodContext _context;
        public FavoriteFoodContextDAO(FavoriteFoodContext context)
        {
            _context = context;
        }

        public List<FavoriteFood> GetFavoriteFoods()
        {
            return _context.FavoriteFoods.ToList();
        }

        public FavoriteFood GetFavoriteFoodById(int id)
        {
            return _context.FavoriteFoods.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveFavoriteFoodById(int id)
        {
            var foods = this.GetFavoriteFoodById(id);
            if (foods == null) return null;
            try
            {
                _context.FavoriteFoods.Remove(foods);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public int? UpdateFavoriteFood(FavoriteFood name)
        {
            var foodToUpdate = this.GetFavoriteFoodById(name.Id);
            if (foodToUpdate == null)
                return null;

            foodToUpdate.FavBreak = name.FavBreak;
            foodToUpdate.FavLunch = name.FavLunch;
            foodToUpdate.FavDin = name.FavDin;
            foodToUpdate.FavDes = name.FavDes;
            try
            {
                _context.FavoriteFoods.Update(foodToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int? Add(FavoriteFood name)
        {
            var names = _context.FavoriteFoods.Where(x => x.FavBreak.Equals(name.FavBreak)).FirstOrDefault();

            if (name == null)
                return null;
            try
            {
                _context.FavoriteFoods.Add(name);
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
