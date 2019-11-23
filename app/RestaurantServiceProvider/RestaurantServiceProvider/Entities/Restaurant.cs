using System;
using System.ComponentModel.DataAnnotations;

namespace RestaurantServiceProvider.Entities
{
    public class Restaurant
    {
        public Restaurant()
        {
        

        }
        [Key]
        public int Id { get;  }
        public string Name { get; }
        public string Address { get; }

        public Menu Menu { get;}

    }
}
