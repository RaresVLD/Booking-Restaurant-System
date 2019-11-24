using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider.Utils
{
    static public class CommandSeed
    {
       public static Command[] CreateCommands()
        {
            return new Command[2]
            {
                Command.Create(13, 11),
                Command.Create(14, 12)
            };
        }
    }
}
