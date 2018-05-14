using System;
using AnOdeToGrub.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnOdeToGrub.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Patrick's Pizzeria" },
                new Restaurant { Id = 2, Name = "The Krusty Krab" },
                new Restaurant { Id = 3, Name = "Plankton's Takee Outee" }
            };
        }       

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        readonly List<Restaurant> _restaurants;
    }
}
