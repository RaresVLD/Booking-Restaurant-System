using Microsoft.AspNetCore.Mvc;
using RestaurantServiceProvider.ServiceRepository;
using System.Collections.Generic;


namespace RestaurantServiceProvider.Controllers
{

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

        [HttpGet("get/id/{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            List<User> users = _user.GetUserById(id);
            return Ok(users);
        }

        [HttpGet("get/firstname/{firstname}")]
        public ActionResult<User> GetUserByFirstName(string firstname)
        {
            List<User> users = _user.GetUserByFirstName(firstname);
            return Ok(users);
        }

        [HttpGet("get/lastname/{lastname}")]
        public ActionResult<User> GetUserByLastName(string lastname)
        {
            List<User> users = _user.GetUserByLastName(lastname);
            return Ok(users);
        }

        [HttpGet("get/email/id/{id}")]
        public ActionResult<User> GetEmailById(int id)
        {
            string email = _user.GetEmailById(id);
            return Ok(email);
        }

        [HttpGet("get/email/name/{name}")]
        public ActionResult<User> GetEmailByName(string name)
        {
            List<string> email = _user.GetEmailByFirstName(name);
            return Ok(email);
        }




    }
}
