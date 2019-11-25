using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantServiceProvider.Entities
{
    public class Reservation
    {
        private Reservation()
        {

        }
        [Key]
        public int Id { get; private set; }
        public int NumberOfPersons { get; private set; }
        public DateTime ReservationDate { get; private set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; private set; }

        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; private set; }

        public Command Command { get; private set; }


        public static Reservation Create(int id, int numberOfPersons, DateTime reservationDate,
            int userId, int restaurantId)
        {
            return new Reservation
            {
                Id = id,
                NumberOfPersons=numberOfPersons,
                ReservationDate=reservationDate,
                UserId = userId,
                RestaurantId = restaurantId,
            };
        }
    }
}
