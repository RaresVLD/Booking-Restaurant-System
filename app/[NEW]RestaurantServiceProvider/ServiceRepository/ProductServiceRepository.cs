using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider.ServiceRepository
{
    public class ProductServiceRepository : IProductServiceRepository
    {
        private RestaurantServiceProviderContext db;


        public ProductServiceRepository(RestaurantServiceProviderContext context)
        {
            db = context;
        }


        public List<Product> GetAllProducts() => db.Products.ToList();


        public List<Product> GetAllProductsGivenBookingDateTime(DateTime dateTime)
        {
            Booking b = db.Bookings.Include(b => b.Products).Where(b => b.BookingDate.Equals(dateTime)).FirstOrDefault();
            return b.Products.ToList();
        }


        public List<Product> GetAllProductsGivenPriceBelow(int price) => db.Products.Where(p => p.Price < price).ToList();
    }
}
