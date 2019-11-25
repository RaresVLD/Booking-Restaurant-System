using System.Collections.Generic;
using System.Linq;
using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider.ServiceRepository
{
    public interface IMenuServiceRepository
    {
        public abstract IQueryable<Menu> getAllMenus();

        public abstract Menu GetMenuById(int id);

        public abstract List<Product> GetProductsByMenuId(int id);

    }
}
