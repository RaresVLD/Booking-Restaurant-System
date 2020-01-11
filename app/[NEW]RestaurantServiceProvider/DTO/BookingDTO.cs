using System;
using System.Collections.Generic;
using RestaurantServiceProvider.Entities;

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

        public List<Product> Products { get; private set; }

    }
}
