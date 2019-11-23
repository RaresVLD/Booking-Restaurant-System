using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider
{
    public class User
    {
        public User(int id, string firstName, string lastName, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Reservations = new HashSet<Reservation>();

        }
        [Key]
        [Required]
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
        [MaxLength(50)]
        public string Email { get; set; }

        public ICollection<Reservation> Reservations { get; }
    }
}
