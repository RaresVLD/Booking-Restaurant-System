using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider.ServiceRepository
{
    public class MenuServiceRepository : IMenuServiceRepository
    {
        private RestaurantServiceProviderContext db;

        public MenuServiceRepository(RestaurantServiceProviderContext db)
        {
            this.db = db;
        }

        public IQueryable<Menu> getAllMenus()
        {
            return db.Menus;
        }

        public Menu GetMenuById(int id)
        {
            return db.Menus.Find(id);
        }


        public List<Product> GetProductsByMenuId(int id)
        {
            var m = db.Menus.Include(p => p.Products).Where(p => p.Id == id).FirstOrDefault();
            return m.Products.ToList();
        }

        public void UpdateMenuById(int id, Menu newMenu)
        {
            var menu = db.Menus.Where(menu => menu.Id == id).FirstOrDefault();
            menu = newMenu;
            db.SaveChanges();

        }

    }
}
