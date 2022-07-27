using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Interfaces
{
    public interface IFavoriteMusicContextDAO
    {
        List<FavoriteMusic> GetFavoriteMusic();
        FavoriteMusic GetFavoriteMusicById(int id);
        int? RemoveFavoriteMusicById(int id);
        int? UpdateFavoriteMusic(FavoriteMusic name);
        int? Add(FavoriteMusic name);
    }
}
