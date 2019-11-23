using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestaurantServiceProvider.Entities
{
    public class Menu
    {
        public Menu()
        {
            Products = new HashSet<Product>();
        }
        [Key]
        public int Id { get; }

        public ICollection<Product> Products { get; }
        public Restaurant Restaurant { get; }

    }
}
