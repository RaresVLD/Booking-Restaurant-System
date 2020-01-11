using RestaurantServiceProvider.DTO;
using System;

namespace RestaurantServiceProvider.Service
{
    public interface IBookingService
    {
        public abstract void AddBooking(BookingDTO booking);
        public abstract void DeleteBookingGivenId(Guid id);
    }
}
