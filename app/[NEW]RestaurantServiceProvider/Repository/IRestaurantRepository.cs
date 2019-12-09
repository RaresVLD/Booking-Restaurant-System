using RestaurantServiceProvider.Entities;
using System.Collections.Generic;

namespace RestaurantServiceProvider.ServiceRepository
{
    public interface IRestaurantRepository
    {
        public abstract List<Restaurant> GetAllRestaurants();

        public abstract Restaurant GetRestaurantGivenName(string name);

        public abstract Restaurant GetRestaurantGivenAddress(string address);

        public abstract List<Product> GetAllProductsGivenRestaurantName(string name);

        public abstract List<Product> GetAllProductsGivenRestaurantNameAndPriceBelow(string name, int price);

        public abstract void AddRestaurant(Restaurant r);
    }
}
