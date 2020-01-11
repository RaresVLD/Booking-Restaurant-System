using System;
using Microsoft.AspNetCore.Mvc;
using RestaurantServiceProvider.DTO;
using RestaurantServiceProvider.Entities;
using RestaurantServiceProvider.Service;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantServiceProvider.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class BookingsController : Controller
    {
        public IBookingService _bookingService;


        public BookingsController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost]
        public ActionResult AddBooking(BookingDTO bookingDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest("Bad request");
            _bookingService.AddBooking(bookingDTO);
            return Created(nameof(Booking), "Posted");
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteBookingGivenId(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest("Bad Request");
           _bookingService.DeleteBookingGivenId(id);
        
            return NoContent();
        }
    }
}
