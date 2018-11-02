using ASP.CoreFirstApp.Models;
using ASP.CoreFirstApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.CoreFirstApp.Controllers
{
    public class HomeController : Controller
    {

        private IRestaurantData  _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }


        public IActionResult Index()
        {
            var model = _restaurantData.GetAll();

            return View(model);
        }

    }
}
