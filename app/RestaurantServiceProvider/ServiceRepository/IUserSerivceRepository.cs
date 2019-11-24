using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantServiceProvider.ServiceRepository
{
    public interface IUserSerivceRepository
    {
        public abstract List<User> GetUsers();
        public abstract List<User> GetUserById(int id);

        public abstract List<User> GetUserByFirstName(string firstName);
        public abstract List<User> GetUserByLastName(string lastName);

        public abstract string GetEmailById(int id);

        public abstract List<string> GetEmailByName(string name);
    }
}
