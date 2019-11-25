using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurantServiceProvider.Entities;
using RestaurantServiceProvider.ServiceRepository;

namespace RestaurantServiceProvider.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantsController : Controller
    {
        public IRestaurantServiceRepository _restaurants;
        public RestaurantsController(IRestaurantServiceRepository restaurant)
        {
            _restaurants = restaurant;
        }

        [HttpGet]
        public ActionResult Get()
        {
            List<Restaurant> restaurants = _restaurants.GetAllRestaurants();
            return Ok(restaurants);
        }

        [HttpGet("get/id/{id}")]
        public ActionResult GetRestaurantsById(int id)
        {
            List<Restaurant> restaurants = _restaurants.GetRestaurantById(id);
            return Ok(restaurants);
        }
        [HttpGet("get/menu/restaurant/{name}")]
        public ActionResult GetMenuByRestaurantName(string name)
        {
            List<Menu> menu = _restaurants.GetMenuByRestaurantName(name);
            return Ok(menu);
        }
    }
}