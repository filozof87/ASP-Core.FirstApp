using ASP.CoreFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.CoreFirstApp.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurants> GetAll();
    }

    public class InMemoryRestaurantData: IRestaurantData
    {

        public  InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurants>
            {
                new Restaurants {Id=1, Name="Restoran 1" },
                new Restaurants { Id = 2, Name = "Restoran 2" },
                new Restaurants {Id = 3, Name = "Restoran 3" }
            };

        }
        
        public IEnumerable<Restaurants> GetAll()
        {
        return _restaurants;
        }

        List<Restaurants> _restaurants;
    }
}

