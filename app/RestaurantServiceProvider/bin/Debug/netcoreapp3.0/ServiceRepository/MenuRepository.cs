using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider.ServiceRepository
{
    public class MenuRepository
    {
        private RestaurantServiceProviderContext db;
        public MenuRepository(RestaurantServiceProviderContext db)
        {
            this.db = db;
        }

        public IQueryable<Menu> getAllMenus()
        {
            return db.Menus;
        }

        public Menu GetMenuForSpecificRestaurantGivenId(int id)
        {
            return db.Menus.Where(m => m.Id == id).FirstOrDefault();
        }

        public Menu GetMenuForSpecificRestaurantGivenName(string name)
        {

            return db.Menus.Include(r => r.Restaurant).ToList().
                   Where(m => m.Restaurant.Name == name).FirstOrDefault();
        }




    }
}
