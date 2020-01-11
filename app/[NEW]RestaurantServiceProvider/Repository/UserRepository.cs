using Microsoft.EntityFrameworkCore;
using RestaurantServiceProvider.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantServiceProvider.ServiceRepository
{
    public class UserRepository : IUserRepository
    {
        private RestaurantServiceProviderContext db;


        public UserRepository(RestaurantServiceProviderContext context)
        {
            db = context;
        }


        public void AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public List<Booking> GetAllBookingsGivenEmail(string email) => db.Users.Include(u => u.Bookings)
                                                                          .Where(u => u.Email == email)
                                                                          .FirstOrDefault().Bookings.ToList();

        public List<User> GetAllUsers() => db.Users.ToList();
    }
}
