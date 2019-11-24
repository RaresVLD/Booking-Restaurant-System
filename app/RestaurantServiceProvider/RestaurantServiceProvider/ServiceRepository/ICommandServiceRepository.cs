using System.Collections.Generic;
using System.Linq;
using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider.ServiceRepository
{
    public interface ICommandServiceRepository
    {
        public abstract IQueryable<Command> GetAllCommands();


        public abstract List<Product> GetProductsForCommandId(int id);

        public abstract Command GetCommandById(int id);
    }
}
