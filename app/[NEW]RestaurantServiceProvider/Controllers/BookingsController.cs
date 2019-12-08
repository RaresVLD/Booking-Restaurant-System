using System;
using Microsoft.AspNetCore.Mvc;
using RestaurantServiceProvider.DTO;
using RestaurantServiceProvider.Entities;
using RestaurantServiceProvider.ServiceRepository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantServiceProvider.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class BookingsController : Controller
    {
        public IBookingServiceRepository _bookingRepository;


        public BookingsController(IBookingServiceRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        [HttpPost]
        public ActionResult AddBooking(BookingDTO bookingDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest("bad request");
            _bookingRepository.AddBooking(Booking.Create(bookingDTO));
            return Created(nameof(Booking), "posted");
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteBookingGivenId(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest("bad request");
           _bookingRepository.DeleteBookingGivenId(id);
        
            return NoContent();
        }
    }
}
