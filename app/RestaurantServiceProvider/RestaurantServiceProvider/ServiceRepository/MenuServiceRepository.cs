using Microsoft.EntityFrameworkCore;
using RestaurantServiceProvider.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantServiceProvider.ServiceRepository
{
    
    public class MenuServiceRepository
    {
        DbSet<Menu> menus;
        MenuServiceRepository(RestaurantServiceProviderContext context)
        {
            menus = context.Menus;
        }
        public List<Menu> GetMenuById(int id) => menus.Where(menu => menu.Id == id).ToList();
        public ICollection<Product> GetProductsFromMenu(Menu menu) => menus.Where(m => m.Id == menu.Id)
                                                                           .Select(m => m.Products).ToList()[0];
        public List<Restaurant> GetRestaurantsFromMenu(Menu menu) => menus.Where(m => m.Id == menu.Id)
                                                                          .Select(m => m.Restaurant).ToList();
    }
}
