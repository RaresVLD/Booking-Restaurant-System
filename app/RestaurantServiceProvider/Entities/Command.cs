using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantServiceProvider.Entities
{
    public class Command
    {
        private Command()
        {

        }
        [Key]
        public int Id { get; private set; }
        public ICollection<Product> Products { get; private set; }
        [ForeignKey("Reservation")]
        public int ReservationId { get; set; }
        public Reservation Reservation { get; private set; }

        public static Command Create(int id, int reservationId)
        {
            return new Command
            {
                Id = id,
                Products = new HashSet<Product>(),
                ReservationId = reservationId
            };
        }
    }
}
