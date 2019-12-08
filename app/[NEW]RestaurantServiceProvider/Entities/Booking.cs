using RestaurantServiceProvider.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RestaurantServiceProvider.Entities
{
    public class Booking
    {
        private Booking()
        {

        }
        [Key]
        public Guid Id { get; private set; }

        public int NumberOfPersons { get; private set; }

        public DateTime BookingDate { get; private set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }

        public virtual User User { get; private set; }

        [ForeignKey("Restaurant")]
        public Guid RestaurantId { get; set; }


        public virtual ICollection<Product> Products { get; private set; }


        public static Booking Create(int numberOfPersons, DateTime bookingDate, Guid userId, Guid restaurantId)
        {
            return new Booking
            {
                Id = Guid.NewGuid(),
                NumberOfPersons = numberOfPersons,
                BookingDate = bookingDate,
                UserId = userId,
                RestaurantId = restaurantId,
            };
        }

        public static Booking Create(BookingDTO bookingDTO)
        {
            return Booking.Create(bookingDTO.NumberOfPersons, bookingDTO.BookingDate, bookingDTO.UserId, bookingDTO.RestaurantId);
        }
    }
}
