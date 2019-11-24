using System;
using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider.Utils
{
    public static class RestaurantSeed
    {
        public static Restaurant[] CreateRestaurants()
        {
            return new Restaurant[2] {
                Restaurant.Create(1, "Mamma Mia", "Bulevardul Stefan cel Mare si Sfant 4"),
                Restaurant.Create(2, "Serginio", "Strada Han Tătar Bloc 361")
            };
        }
    }
}
