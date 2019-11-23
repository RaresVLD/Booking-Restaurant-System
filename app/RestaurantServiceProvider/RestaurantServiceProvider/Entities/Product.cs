using System;
using System.ComponentModel.DataAnnotations;

namespace RestaurantServiceProvider.Entities
{
    public class Product
    {
        public Product()
        {
        }
        [Key]
        public int Id { get;  }
        public string Name { get; }
        public double Price { get; }

        public Menu Menu { get; }
    }
}
