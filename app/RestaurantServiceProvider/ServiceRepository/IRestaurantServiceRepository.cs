using RestaurantServiceProvider.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantServiceProvider.ServiceRepository
{
    public interface IRestaurantServiceRepository
    {
        public abstract List<Restaurant> GetAllRestaurants();
        public abstract List<Restaurant> GetRestaurantById(int id);

        public abstract List<Restaurant> GetRestaurantsByName(string name);

        public abstract List<Restaurant> GetRestaurantsByAddress(string address);

        public abstract List<Menu> GetMenuByRestaurantName(string name);
    }
}
