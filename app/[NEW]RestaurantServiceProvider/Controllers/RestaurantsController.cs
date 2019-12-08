using Microsoft.AspNetCore.Mvc;
using RestaurantServiceProvider.DTO;
using RestaurantServiceProvider.Entities;
using RestaurantServiceProvider.ServiceRepository;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantServiceProvider.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class RestaurantsController : Controller
    {
        public IRestaurantServiceRepository _restaurantRepository;


        public RestaurantsController(IRestaurantServiceRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }


        [HttpGet]
        public ActionResult Get()
        {
            List<Restaurant> restaurants = _restaurantRepository.GetAllRestaurants();
            return Ok(restaurants);
        }


        [HttpGet("name/{name}")]
        public ActionResult GetRestaurantGivenName(string name)
        {
            Restaurant restaurant = _restaurantRepository.GetRestaurantGivenName(name);
            return Ok(restaurant);
        }


        [HttpGet("address/{address}")]
        public ActionResult GetRestaurantGivenAddress(string address)
        {
            Restaurant restaurant = _restaurantRepository.GetRestaurantGivenAddress(address);
            return Ok(restaurant);
        }


        [HttpGet("name/{name}/products")]
        public ActionResult GetAllProductsGivenRestaurantName(string name)
        {
            List<Product> products = _restaurantRepository.GetAllProductsGivenRestaurantName(name);
            return Ok(products);
        }


        [HttpGet("name/{name}/products/price/{price}")]
        public ActionResult GetAllProductsGivenRestaurantNameAndPriceBelow(string name, int price)
        {
            List<Product> products = _restaurantRepository.GetAllProductsGivenRestaurantNameAndPriceBelow(name, price);
            return Ok(products);
        }

        [HttpPost]
        public ActionResult AddRestaurant(RestaurantDTO restaurantDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest("bad request");
            _restaurantRepository.AddRestaurant(Restaurant.Create(restaurantDTO));
            return Created(nameof(Restaurant), "posted");
        }
    }
}
