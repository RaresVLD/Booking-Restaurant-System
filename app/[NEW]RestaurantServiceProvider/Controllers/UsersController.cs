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
        public IUserServiceRepository _users;


        public UsersController(IUserServiceRepository user)
        {
            _users = user;
        }


        [HttpGet]
        public ActionResult Get()
        {
            List<User> users = _users.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("email/{email}/bookings")]
        public ActionResult GetAllBookingsGivenEmail(string email)
        {
            List<Booking> bookings = _users.GetAllBookingsGivenEmail(email);
            return Ok(bookings);
        }


        [HttpPost]
        public ActionResult AddUser(UserDTO userDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest("bad request");
            _users.AddUser(Entities.User.Create(userDTO));
            return Ok();
        }
    }
}
