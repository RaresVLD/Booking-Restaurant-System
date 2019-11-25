using System.Collections.Generic;
using System.Linq;
using RestaurantServiceProvider.Entities;
namespace RestaurantServiceProvider.ServiceRepository
{
    public class ProductServiceRepository : IProductServiceRepository
    {
        private RestaurantServiceProviderContext db;

        public ProductServiceRepository(RestaurantServiceProviderContext db)
        {
            this.db = db;
        }

        public List<Product> GetProducts() => db.Products.ToList();

        public List<Product> GetProductsById(int id) => db.Products.Where(product => product.Id == id).ToList();


        public List<Product> GetProductsByName(string name) => db.Products.Where(product => product.Name == name).ToList();


        public List<Product> GetProductsByPrice(double price) => db.Products.Where(product => product.Price == price).ToList();

        public List<Product> GetProductsByMenuId(int id) => db.Products.Where(product => product.Menu.Id == id).ToList();

    }
}
