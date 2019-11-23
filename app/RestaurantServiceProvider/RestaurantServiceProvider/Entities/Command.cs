using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestaurantServiceProvider.Entities
{
    public class Command
    {
        public Command()
        {
        }
        [Key]
        public int Id { get; }

        public ICollection<Product> Products { get; }
        public User User { get; set; }
    }
}
