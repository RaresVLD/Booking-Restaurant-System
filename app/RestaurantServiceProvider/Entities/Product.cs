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
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }

        [ForeignKey("Menu")]
        public int MenuId { get; set; }
        public Menu Menu { get; private set; }

        public static Product Create(int id, string name, double price, int menuId)
        {
            return new Product
            {
                Id=id,
                Name=name,
                Price=price,
                MenuId = menuId
            };
        }
    }
}
