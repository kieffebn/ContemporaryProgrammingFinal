using FinalProject.Interfaces;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data
{
    public class FavoriteVenueContextDAO : IFavoriteVenueContextDAO
    {
        private FavoriteVenueContext _context;
        public FavoriteVenueContextDAO(FavoriteVenueContext context)
        {
            _context = context;
        }

        public List<FavoriteVenue> GetFavoriteVenues()
        {
            return _context.FavoriteVenues.ToList();
        }

        public FavoriteVenue GetFavoriteVenueById(int id)
        {
            return _context.FavoriteVenues.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveFavoriteVenueById(int id)
        {
            var name = this.GetFavoriteVenueById(id);
            if (name == null) return null;
            try
            {
                _context.FavoriteVenues.Remove(name);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int? UpdateFavoriteVenue(FavoriteVenue name)
        {
            var venueToUpdate = this.GetFavoriteVenueById(name.Id);
            if (venueToUpdate == null)
                return null;

            venueToUpdate.FavRestaraunt = name.FavRestaraunt;
            venueToUpdate.FavBar = name.FavBar;
            venueToUpdate.FavPark = name.FavPark;
            venueToUpdate.FavStadium = name.FavStadium;
            try
            {
                _context.FavoriteVenues.Update(venueToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int? Add(FavoriteVenue name)
        {
            var names = _context.FavoriteVenues.Where(x => x.FavBar.Equals(name.FavBar)).FirstOrDefault();

            if (name == null)
                return null;
            try
            {
                _context.FavoriteVenues.Add(name);
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