using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IBookingServiceRepository _bookings;


        public BookingsController(IBookingServiceRepository bookings)
        {
            _bookings = bookings;
        }

        [HttpPost]
        public ActionResult AddRestaurant(BookingDTO bookingDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest("bad request");
            _bookings.AddBooking(Booking.Create(bookingDTO));
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteBookingGivenId(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest("bad request");
           _bookings.DeleteBookingGivenId(id);
        
            return Ok();
        }
    }
}
