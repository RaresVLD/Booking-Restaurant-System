using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RestaurantServiceProvider.Crawlers;
using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider.ServiceRepository
{
    public class ProductRepository : IProductRepository
    {
        private RestaurantServiceProviderContext db;


        public ProductRepository(RestaurantServiceProviderContext context)
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

        public void InsertProductsFromCrawler()
        {
            var products = new ProductsCrawler().GetProductsForRestaurants(db);
            foreach(var product in products)
            {
                db.Products.Add(product);
            }
            db.SaveChanges();
        }
    }
}
