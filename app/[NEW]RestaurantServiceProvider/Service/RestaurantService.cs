using System;
using System.Collections.Generic;
using RestaurantServiceProvider.DTO;
using RestaurantServiceProvider.Entities;
using RestaurantServiceProvider.ServiceRepository;

namespace RestaurantServiceProvider.Service
{
    public class RestaurantService : IRestaurantService
    {
        IRestaurantRepository _restaurantRepository;
        public RestaurantService(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }
        public void AddRestaurant(RestaurantDTO restaurantDTO)
        {
            _restaurantRepository.AddRestaurant(Restaurant.Create(restaurantDTO));
        }

        public List<Product> GetAllProductsGivenRestaurantName(string name)
        {

            return _restaurantRepository.GetAllProductsGivenRestaurantName(name);
        }

        public List<Product> GetAllProductsGivenRestaurantNameAndPriceBelow(string name, int price)
        {
            return _restaurantRepository.GetAllProductsGivenRestaurantNameAndPriceBelow(name, price);
        }

        public List<Restaurant> GetAllRestaurants()
        {
            return _restaurantRepository.GetAllRestaurants();
        }

        public Restaurant GetRestaurantGivenAddress(string address)
        {
            return _restaurantRepository.GetRestaurantGivenAddress(address);
        }

        public Restaurant GetRestaurantGivenName(string name)
        {
            return _restaurantRepository.GetRestaurantGivenName(name);
        }

        public List<RestaurantDTO> GetRestaurantsInfo()
        {
            return _restaurantRepository.GetRestaurantsInfo();
        }
    }
}
