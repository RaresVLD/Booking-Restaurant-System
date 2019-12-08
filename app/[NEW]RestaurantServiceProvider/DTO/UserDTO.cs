using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantServiceProvider.DTO
{
    public class UserDTO
    {
        public UserDTO()
        {

        }

        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
    }
}
