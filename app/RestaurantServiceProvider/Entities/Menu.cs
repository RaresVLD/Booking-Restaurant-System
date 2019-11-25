using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantServiceProvider.Entities
{
    public class Menu
    {
        private Menu()
        {
            
        }
        [Key]
        public int Id { get; private set; }
        public ICollection<Product> Products { get; private set; }

        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get;  set; }

        public static Menu Create(int id, int restaurantID)
        {
            return new Menu
            {
                Id = id,
                Products = new HashSet<Product>(),
                RestaurantId = restaurantID
            };
        }

    }
}
