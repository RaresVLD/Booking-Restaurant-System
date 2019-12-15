using RestaurantServiceProvider.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestaurantServiceProvider.Entities
{
    public class Restaurant
    {
        private Restaurant()
        {


        }

        [Key]
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Address { get; private set; }

        public string Description { get; private set; }


        public virtual ICollection<Product> Products { get; private set; }

        public static Restaurant Create(string name, string address, string description)
        {
            return new Restaurant
            {
                Id = Guid.NewGuid(),
                Name = name,
                Address = address,
                Description = description,
                Products = new HashSet<Product>()
            };
        }

        public static Restaurant Create(RestaurantDTO restaurantDTO)
        {
            if (restaurantDTO.Name == null)
                throw new Exception();
            return Create(restaurantDTO.Name, restaurantDTO.Address, restaurantDTO.Description);
        }
    }
}
