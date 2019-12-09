using RestaurantServiceProvider.Entities;
using System;
using System.Collections.Generic;

namespace RestaurantServiceProvider.ServiceRepository
{
    public interface IProductRepository
    {
        public abstract List<Product> GetAllProducts();
        public abstract List<Product> GetAllProductsGivenBookingDateTime(DateTime dateTime);
        public abstract List<Product> GetAllProductsGivenPriceBelow(int price);
    }
}
