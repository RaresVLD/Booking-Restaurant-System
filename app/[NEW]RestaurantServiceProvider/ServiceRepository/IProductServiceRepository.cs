using RestaurantServiceProvider.Entities;
using System;
using System.Collections.Generic;

namespace RestaurantServiceProvider.ServiceRepository
{
    public interface IProductServiceRepository
    {
        public abstract List<Product> GetAllProducts();


        public abstract List<Product> GetAllProductsGivenBookingDateTime(DateTime dateTime);

        public abstract List<Product> GetAllProductsGivenPriceBelow(int price);

    }
}
