using Microsoft.AspNetCore.Mvc;
using RestaurantServiceProvider.DTO;
using RestaurantServiceProvider.Entities;
using RestaurantServiceProvider.ServiceRepository;
using System.Collections.Generic;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantServiceProvider.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class UsersController : Controller
    {
        public IUserServiceRepository _userRepository;


        public UsersController(IUserServiceRepository userRepository)
        {
            _userRepository = userRepository;
        }


        [HttpGet]
        public IActionResult Get()
        {
            List<User> users = _userRepository.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("email/{email}/bookings")]
        public IActionResult GetAllBookingsGivenEmail(string email)
        {
            List<Booking> bookings = _userRepository.GetAllBookingsGivenEmail(email);
            return Ok(bookings);
        }


        [HttpPost]
        public IActionResult AddUser(UserDTO userDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest("bad request");
            _userRepository.AddUser(Entities.User.Create(userDTO));
            return Created(nameof(User), "posted");
        }
    }
}
