using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RestaurantServiceProvider.Entities;
namespace RestaurantServiceProvider.ServiceRepository
{
    public class ProductServiceRepository : IProductServiceRepository
    {
        DbSet<Product> products;

        ProductServiceRepository(RestaurantServiceProviderContext context)
        {
            products = context.Products;
        }
        public List<Product> GetProducts() => products.ToList();
        public List<Product> GetProductsById(int id) => products.Where(product => product.Id == id).ToList();

        public List<Product> GetProductsByName(string name) => products.Where(product => product.Name == name).ToList();

        public List<Product> GetProductsByPrice(double price) => products.Where(product => product.Price == price).ToList();

        public List<Product> GetProductsByMenuId(int id) => products.Where(product => product.Menu.Id == id).ToList();
    }
}
