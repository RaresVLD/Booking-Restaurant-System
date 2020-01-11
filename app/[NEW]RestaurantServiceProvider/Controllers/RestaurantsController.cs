using Microsoft.AspNetCore.Mvc;
using RestaurantServiceProvider.DTO;
using RestaurantServiceProvider.Entities;
using RestaurantServiceProvider.Service;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantServiceProvider.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class RestaurantsController : Controller
    {
        public IRestaurantService _restaurantService;


        public RestaurantsController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        /*
        [HttpGet]
        public ActionResult Get()
        {
            List<Restaurant> restaurants = _restaurantService.GetAllRestaurants();
            return Ok(restaurants);
        }*/

        
        [HttpGet("name/{name}")]
        public ActionResult GetRestaurantGivenName(string name)
        {
            Restaurant restaurant = _restaurantService.GetRestaurantGivenName(name);
            return Ok(restaurant);
        }

        [HttpGet]
        public ActionResult GetRestaurantsInfo()
        {
            List<RestaurantDTO> restaurants = _restaurantService.GetRestaurantsInfo();
            return Ok(restaurants);
        }


        [HttpGet("address/{address}")]
        public ActionResult GetRestaurantGivenAddress(string address)
        {
            Restaurant restaurant = _restaurantService.GetRestaurantGivenAddress(address);
            return Ok(restaurant);
        }


        [HttpGet("name/{name}/products")]
        public ActionResult GetAllProductsGivenRestaurantName(string name)
        {
            List<Product> products = _restaurantService.GetAllProductsGivenRestaurantName(name);
            return Ok(products);
        }


        [HttpGet("name/{name}/products/price/{price}")]
        public ActionResult GetAllProductsGivenRestaurantNameAndPriceBelow(string name, int price)
        {
            List<Product> products = _restaurantService.GetAllProductsGivenRestaurantNameAndPriceBelow(name, price);
            return Ok(products);
        }

        [HttpPost]
        public ActionResult AddRestaurant(RestaurantDTO restaurantDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest("bad request");
            _restaurantService.AddRestaurant(restaurantDTO);
            return Created(nameof(Restaurant), "posted");
        }
    }
}
