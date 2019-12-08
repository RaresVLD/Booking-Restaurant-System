using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantServiceProvider.Entities
{
    public class Product
    {
        private Product()
        {

        }

        [Key]
        public Guid Id { get; private set; }

        [ForeignKey("RestaurantId")]
        public Guid RestaurantId { get; private set; }
        public virtual Restaurant Restaurant { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public double Price { get; private set; }

        public virtual ICollection<Booking> Bookings { get; private set; }

        public static Product Create(Guid restaurantId, string name, string description, double price)
        {
            return new Product
            {
                Id = Guid.NewGuid(),
                RestaurantId = restaurantId,
                Name = name,
                Description = description,
                Price = price,
                Bookings = new HashSet<Booking>()
            };
        }
    }
}
