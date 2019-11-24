using Microsoft.AspNetCore.Mvc;
using RestaurantServiceProvider.ServiceRepository;
using System.Collections.Generic;


namespace RestaurantServiceProvider.Controllers {

    [ApiController]
    [Route("[controller]")]

    public class UsersController : ControllerBase
    {
        public IUserSerivceRepository _user;

        public UsersController(IUserSerivceRepository user)
        {
            _user = user;
        }

        [HttpGet]
        public ActionResult<User> Get()
        {
            List<User> users = _user.GetUsers();
            return Ok(users);
        }

        [HttpGet("get/{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            List<User> users = _user.GetUserById(id);
            return Ok(users);
        }

        [HttpGet("get/{firstname}")]
        public ActionResult<User> GetUserByFirstName(string firstname)
        {
            List<User> users = _user.GetUserByFirstName(firstname);
            return Ok(users);
        }
        



    }
}
