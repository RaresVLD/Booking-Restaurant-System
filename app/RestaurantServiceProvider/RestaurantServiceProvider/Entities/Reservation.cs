using System;
using System.ComponentModel.DataAnnotations;

namespace RestaurantServiceProvider.Entities
{
    public class Reservation
    {
        public Reservation()
        {
        }
        [Key]
        public int Id { get; }
        public int NumberOfPersons { get; }
        public DateTime ReservationDate { get; set; }

        public User User { get; }
        public Restaurant Restaurant { get; }
        public Command Command { get; }
    }
}
