using RestaurantServiceProvider.Entities;
using System;

namespace RestaurantServiceProvider.ServiceRepository
{
    public interface IBookingRepository
    {
        public abstract void AddBooking(Booking booking);

        public abstract void DeleteBookingGivenId(Guid id);
    }
}
