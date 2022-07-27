using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Interfaces
{
    public interface IFavoriteFoodContextDAO
    {
        List<FavoriteFood> GetFavoriteFoods();
        FavoriteFood GetFavoriteFoodById(int id);
        int? RemoveFavoriteFoodById(int id);
        int? UpdateFavoriteFood(FavoriteFood name);
        int? Add(FavoriteFood name);
    }
}
