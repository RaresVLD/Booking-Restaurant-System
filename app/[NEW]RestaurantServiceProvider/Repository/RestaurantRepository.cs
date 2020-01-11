using Microsoft.EntityFrameworkCore;
using RestaurantServiceProvider.DTO;
using RestaurantServiceProvider.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantServiceProvider.ServiceRepository
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private RestaurantServiceProviderContext db;

        public RestaurantRepository(RestaurantServiceProviderContext context)
        {
            db = context;
        }

        public List<Restaurant> GetAllRestaurants() => db.Restaurants.Include(r => r.Products).ToList();

        public Restaurant GetRestaurantGivenName(string name) => db.Restaurants.Include(r => r.Products).Where(r => r.Name == name).FirstOrDefault();

        public Restaurant GetRestaurantGivenAddress(string address) => db.Restaurants.Include(r => r.Products).Where(r => r.Address == address).FirstOrDefault();

        public List<Product> GetAllProductsGivenRestaurantName(string name)
        {
            Restaurant r = db.Restaurants.Include(r => r.Products).Where(r => r.Name == name).FirstOrDefault();
            return r.Products.ToList();
        }

        public List<Product> GetAllProductsGivenRestaurantNameAndPriceBelow(string name, int price) => db.Restaurants.Include(r => r.Products)
                                                                                                       .Where(r => r.Name == name)
                                                                                                       .FirstOrDefault()
                                                                                                       .Products.Where(p => p.Price < price)
                                                                                                       .ToList();
        public Guid GetRestaurantIdGivenRestaurantName(string name) => db.Restaurants.Where(r => r.Name == name).FirstOrDefault().Id;

        public void AddRestaurant(Restaurant r)
        {
            db.Restaurants.Add(r);
            db.SaveChanges();
        }

        public List<RestaurantDTO> GetRestaurantsInfo()
        {
            var restaurants = db.Restaurants;
            var restaurantsDTO = new List<RestaurantDTO>();
            foreach(var restaurant in restaurants)
            {
                restaurantsDTO.Add(new RestaurantDTO(restaurant.Name, restaurant.Address, restaurant.Description));
            }
            return restaurantsDTO;
        }
    }
}
