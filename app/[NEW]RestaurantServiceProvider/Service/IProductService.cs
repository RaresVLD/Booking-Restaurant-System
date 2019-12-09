using RestaurantServiceProvider.Entities;
using System;
using System.Collections.Generic;


namespace RestaurantServiceProvider.Service
{
    public interface IProductService
    {
        public abstract List<Product> GetAllProducts();
        public abstract List<Product> GetAllProductsGivenBookingDateTime(DateTime dateTime);
        public abstract List<Product> GetAllProductsGivenPriceBelow(int price);
    }
}
