using Microsoft.EntityFrameworkCore;
using RestaurantServiceProvider.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantServiceProvider.ServiceRepository
{
    public class ProductServiceRepository
    {
        DbSet<Product> products;

        ProductServiceRepository(RestaurantServiceProviderContext context)
        {
            products = context.Products;
        }

        public List<Product> GetProductsById(int id) => products.Where(product => product.Id == id).ToList();

        public List<Product> GetProductsByName(string name) => products.Where(product => product.Name == name).ToList();

        public List<Product> GetProductsByPrice(int price) => products.Where(product => product.Price == price).ToList();

        public List<Product> GetProductsByMenu(Menu menu) => products.Where(product => product.Menu.Id == menu.Id).ToList();
    }
}
