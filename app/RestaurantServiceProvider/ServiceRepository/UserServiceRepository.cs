
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
namespace RestaurantServiceProvider.ServiceRepository
{
    
    public class UserServiceRepository : IUserSerivceRepository
    {
        private DbSet<User> users;

        public UserServiceRepository(RestaurantServiceProviderContext dbContext){
            users = dbContext.Users;
        }
        public List<User> GetUsers() => users.ToList();
        public List<User> GetUserById(int id) => users.Where(usr => usr.Id == id).ToList();  

        public List<User> GetUserByFirstName(string firstName) => users.Where(usr => usr.FirstName == firstName).ToList();

        public List<User> GetUserByLastName(string lastName) => users.Where(usr => usr.LastName == lastName).ToList();

        public string GetEmailById(int id) => users.Where(usr => usr.Id == id).ToList()[0].Email;

        public List<string> GetEmailByName(string name) => users.Where(usr => usr.FirstName == name)
                                                                .Select(usr => usr.Email).ToList();
    }
}
