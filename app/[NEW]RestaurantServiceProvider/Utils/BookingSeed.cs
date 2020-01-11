using System.Collections.Generic;
using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider.Utils
{
    public static class BookingSeed
    {
        public static Booking[] CreateBookings(User[] users, Restaurant[] restaurants, Product[] products)
        {

            return new Booking[2]
            {
                Booking.Create(3, new System.DateTime(2019, 12, 10, 12, 12, 12), users[0].Id, restaurants[0].Id, new List<Product>()),
                Booking.Create(5, new System.DateTime(2019, 10, 10, 10, 10, 10), users[1].Id, restaurants[1].Id, new List<Product>())
            };
        }
    }
}
