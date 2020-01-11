using Microsoft.AspNetCore.Mvc;
using RestaurantServiceProvider.DTO;
using RestaurantServiceProvider.Entities;
using RestaurantServiceProvider.Service;
using RestaurantServiceProvider.ServiceRepository;
using System.Collections.Generic;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantServiceProvider.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class UsersController : Controller
    {
        public IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public IActionResult Get()
        {
            List<User> users = _userService.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("email/{email}/bookings")]
        public IActionResult GetAllBookingsGivenEmail(string email)
        {
            List<Booking> bookings = _userService.GetAllBookingsGivenEmail(email);
            return Ok(bookings);
        }


        [HttpPost]
        public IActionResult AddUser(UserDTO userDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest("Bad Request");
            _userService.AddUser(userDTO);
            return Created(nameof(User), "Posted");
        }
    }
}
