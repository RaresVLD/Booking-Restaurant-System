using RestaurantServiceProvider.Entities;
using System;

namespace RestaurantServiceProvider.ServiceRepository
{
    public class BookingServiceRepository : IBookingServiceRepository
    {
        private RestaurantServiceProviderContext db;

        public BookingServiceRepository(RestaurantServiceProviderContext context)
        {
            db = context;
        }
        public void AddBooking(Booking booking)
        {
            db.Bookings.Add(booking);
            db.SaveChanges();
        }

        public void DeleteBookingGivenId(Guid id)
        {
            Booking booking = db.Bookings.Find(id);
            db.Bookings.Remove(booking);
            db.SaveChanges();
        }

    }
}
