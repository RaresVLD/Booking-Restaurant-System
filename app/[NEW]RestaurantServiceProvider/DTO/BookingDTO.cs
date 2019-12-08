using System;

namespace RestaurantServiceProvider.DTO
{
    public class BookingDTO
    {
        public BookingDTO()
        {

        }

        public int NumberOfPersons { get; set; }

        public DateTime BookingDate { get; set; }

        public Guid UserId { get; set; }

        public Guid RestaurantId { get; set; }
    }
}
