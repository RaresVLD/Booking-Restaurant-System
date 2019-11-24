using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider.ServiceRepository
{
    public class CommandServiceRepository:ICommandServiceRepository
    {
        DbSet<Command> commands;

        CommandServiceRepository(RestaurantServiceProviderContext context)
        {
            commands = context.Commands;
        }
        public IQueryable<Command> GetAllCommands()
        {
            return commands;
        }

        public List<Product> GetProductsForCommandId(int id)
        {
            return commands.Find(id).Products.ToList();
        }

        public Command GetCommandById(int id)
        {
            return commands.Find(id);
        }

    }
}
