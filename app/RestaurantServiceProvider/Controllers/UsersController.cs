<<<<<<< HEAD:app/RestaurantServiceProvider/RestaurantServiceProvider/Controllers/UsersController.cs
﻿using Microsoft.AspNetCore.Mvc;
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
=======
﻿using Microsoft.AspNetCore.Mvc;
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
    }
}
>>>>>>> master:app/RestaurantServiceProvider/Controllers/UsersController.cs
