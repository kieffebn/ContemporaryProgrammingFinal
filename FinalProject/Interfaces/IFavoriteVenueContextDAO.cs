using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Interfaces
{
    public interface IFavoriteVenueContextDAO
    {
        List<FavoriteVenue> GetFavoriteVenues();
        FavoriteVenue GetFavoriteVenueById(int id);
        int? RemoveFavoriteVenueById(int id);
        int? UpdateFavoriteVenue(FavoriteVenue name);
        int? Add(FavoriteVenue name);
    }
}

