using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class FavoriteVenue
    {
        public int Id { get; set; }
        public string FavRestaraunt { get; set; }

        public string FavBar { get; set; }

        public string FavPark { get; set; }

        public string FavStadium { get; set; }
    }
}
