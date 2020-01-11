using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider.Utils
{
    public static class BookingSeed
    {
        public static Booking[] CreateBookings(User[] users, Restaurant[] restaurants, Product[] products)
        {
            Product[] products1 = new Product[2]
            {
                products[0],
                products[1]
            };

            Product[] products2 = new Product[2]
            {
                products[2],
                products[3]
            };

            return new Booking[2]
            {
                Booking.Create(3, new System.DateTime(2019, 12, 10, 12, 12, 12), users[0].Id, restaurants[0].Id/*, products1*/),
                Booking.Create(5, new System.DateTime(2019, 10, 10, 10, 10, 10), users[1].Id, restaurants[1].Id/*, products1*/)
            };
        }
    }
}
