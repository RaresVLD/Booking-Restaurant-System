using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider.ServiceRepository
{
    public class CommandServiceRepository:ICommandServiceRepository
    {

        private RestaurantServiceProviderContext db;

        public CommandServiceRepository(RestaurantServiceProviderContext db)
        {
            this.db = db;
        }

        public List<Command> GetAllCommands()
        {
            return db.Commands.ToList();
        }


        public Command GetCommandById(int id)
        {
            return db.Commands.Find(id);
        }

        public List<Product> GetProductsForCommandId(int id)
        {
            return db.Commands.Find(id).Products.ToList();
        }

    }
}
