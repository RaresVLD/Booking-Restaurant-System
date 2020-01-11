using RestaurantServiceProvider.DTO;
using RestaurantServiceProvider.Entities;
using System.Collections.Generic;


namespace RestaurantServiceProvider.Service
{
    public interface IRestaurantService
    {
        public List<Restaurant> GetAllRestaurants();
        public Restaurant GetRestaurantGivenName(string name);
        public Restaurant GetRestaurantGivenAddress(string address);
        public List<Product> GetAllProductsGivenRestaurantName(string name);
        public List<Product> GetAllProductsGivenRestaurantNameAndPriceBelow(string name, int price);
        public void AddRestaurant(RestaurantDTO r);
        public List<RestaurantDTO> GetRestaurantsInfo();
    }
}
