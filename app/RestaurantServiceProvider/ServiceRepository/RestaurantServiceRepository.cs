using Microsoft.EntityFrameworkCore;
using RestaurantServiceProvider.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantServiceProvider.ServiceRepository
{
    public class RestaurantServiceRepository : IRestaurantServiceRepository
    {
        private DbSet<Restaurant> restaurants;

        public RestaurantServiceRepository(RestaurantServiceProviderContext context)
        {
            restaurants = context.Restaurants;
        }
        public List<Restaurant> GetAllRestaurants() => restaurants.ToList();
        public List<Restaurant> GetRestaurantById(int id) => restaurants.Where(restaurant => restaurant.Id == id).ToList();

        public List<Restaurant> GetRestaurantsByName(string name) => restaurants.Where(restaurant => restaurant.Name == name).ToList();

        public List<Restaurant> GetRestaurantsByAddress(string address) => restaurants.Where(restaurant => restaurant.Address == address).ToList();

        public List<Menu> GetMenuByRestaurantName(string name) => restaurants.Include(r => r.Menu).Where(restaurant => restaurant.Name == name).Select(restaurant => restaurant.Menu).ToList();
    }

}
