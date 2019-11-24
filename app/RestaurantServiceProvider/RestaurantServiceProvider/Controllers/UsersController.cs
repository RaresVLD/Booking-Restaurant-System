using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace RestaurantServiceProvider.Controllers {

    [ApiController]
    [Route("[controller]")]

    public class UsersController : ControllerBase
    {

        public List<User> users;

        public UsersController()
        {
            //users = Utils.SeedUsers();
        }


        [HttpGet]
        public ActionResult<User> Get()
        {
            return Ok(users);    
        }
    }
}
