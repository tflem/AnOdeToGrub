using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnOdeToGrub.Models;
using AnOdeToGrub.Services;
using Microsoft.AspNetCore.Mvc;


namespace AnOdeToGrub.controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;

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