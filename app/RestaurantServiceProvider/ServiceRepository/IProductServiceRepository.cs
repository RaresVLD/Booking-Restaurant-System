using RestaurantServiceProvider.Entities;
using System.Collections.Generic;

namespace RestaurantServiceProvider.ServiceRepository
{
    public interface IProductServiceRepository
    {
        public abstract List<Product> GetProducts();
        public abstract List<Product> GetProductsById(int id);
        public abstract List<Product> GetProductsByName(string name);
        public abstract List<Product> GetProductsByPrice(double price);
        public abstract List<Product> GetProductsByMenuId(int id);
    }
}
