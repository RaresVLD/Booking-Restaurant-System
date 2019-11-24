using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RestaurantServiceProvider.Entities;

<<<<<<< HEAD:app/RestaurantServiceProvider/RestaurantServiceProvider/Entities/User.cs
namespace RestaurantServiceProvider
{
    public class User
    {
        private User()
        {

=======
namespace RestaurantServiceProvider
{
    public class User
    {
        private User()
        {

>>>>>>> master:app/RestaurantServiceProvider/Entities/User.cs
        }
        public static User Create(int id, string firstName, string lastName, string email, string password)
        {
            return new User
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password,
                Reservations = new HashSet<Reservation>()
            };
<<<<<<< HEAD:app/RestaurantServiceProvider/RestaurantServiceProvider/Entities/User.cs
        }
        [Key]
        [Required]
=======
        }
        [Key]
        [Required]
>>>>>>> master:app/RestaurantServiceProvider/Entities/User.cs
        public int Id { get; private set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; private set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; private set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; private set; }

        [Required]
<<<<<<< HEAD:app/RestaurantServiceProvider/RestaurantServiceProvider/Entities/User.cs
        [MaxLength(50)]
        public string Email { get; private set; }

        public ICollection<Reservation> Reservations { get; private set; }
    }
}
=======
        [MaxLength(50)]
        public string Email { get; private set; }

        public ICollection<Reservation> Reservations { get; private set; }
    }
}
>>>>>>> master:app/RestaurantServiceProvider/Entities/User.cs
