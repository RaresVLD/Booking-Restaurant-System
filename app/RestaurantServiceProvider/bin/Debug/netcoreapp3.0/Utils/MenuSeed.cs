using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider.Utils
{
    static public class MenuSeed
    {
        public static Menu[] CreateMenus()
        {
            return new Menu[2] {
               Menu.Create(3, 1),
               Menu.Create(4, 2)};
        }
    }
}
