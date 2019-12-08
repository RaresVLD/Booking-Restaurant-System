using RestaurantServiceProvider.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestaurantServiceProvider.Entities
{
    public class User
    {
        private User()
        {

        }

        [Key]
        public Guid Id { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Email { get; private set; }

        public string Password { get; private set; }

        public virtual ICollection<Booking> Bookings { get; private set; }


        public static User Create(UserDTO userDTO)
        {
            return Create(userDTO.FirstName, userDTO.LastName, userDTO.Email, userDTO.Password);
        }

        public static User Create(string firstName, string lastName, string email, string password)
        {
            return new User
            {
                Id = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password,
                Bookings = new HashSet<Booking>()
            };
        }
    }
}
