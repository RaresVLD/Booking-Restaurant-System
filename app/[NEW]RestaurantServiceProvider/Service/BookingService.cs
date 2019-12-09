using System;
using RestaurantServiceProvider.DTO;
using RestaurantServiceProvider.Entities;
using RestaurantServiceProvider.ServiceRepository;

namespace RestaurantServiceProvider.Service
{
    public class BookingService : IBookingService
    {
        IBookingRepository _bookingRepository;
        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }
        public void AddBooking(BookingDTO bookingDTO)
        {
            _bookingRepository.AddBooking(Booking.Create(bookingDTO));
        }

        public void DeleteBookingGivenId(Guid id)
        {
            _bookingRepository.DeleteBookingGivenId(id);
        }
    }
}
