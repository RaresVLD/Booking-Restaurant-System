using System.ComponentModel.DataAnnotations;

namespace RestaurantServiceProvider.Entities
{
    public class Restaurant
    {
        private Restaurant()
        {
        

        }
        [Key]
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
        public Menu Menu { get; private set; }

        public static Restaurant Create(int id, string name, string address)
        {
            return new Restaurant
            {
                Id=id,
                Name=name,
                Address=address
            };
        }

    }
}
