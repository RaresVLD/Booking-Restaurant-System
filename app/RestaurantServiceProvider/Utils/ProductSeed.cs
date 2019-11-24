using System;
using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider.Utils
{
    static public class ProductSeed
    {
        public static Product[] CreateProducts()
        {
            return new Product[4] {
                Product.Create(5, "Supa", 15, 3),
                Product.Create(6, "Friptura", 20, 3),
                Product.Create(7, "Bors", 19.7, 4),
                Product.Create(8, "Carne", 45, 4)};
        }
    }
}
