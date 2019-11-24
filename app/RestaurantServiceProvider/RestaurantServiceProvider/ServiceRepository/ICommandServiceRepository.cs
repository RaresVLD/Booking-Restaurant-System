using System.Collections.Generic;
using System.Linq;
using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider.ServiceRepository
{
    public interface ICommandServiceRepository
    {
        public abstract IQueryable<Command> GetAllCommands();


        public List<Product> GetProductsForCommandId(int id);

        public Command GetCommandById(int id);
    }
}
