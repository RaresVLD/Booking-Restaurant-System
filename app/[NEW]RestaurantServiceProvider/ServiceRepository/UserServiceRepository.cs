using Microsoft.EntityFrameworkCore;
using RestaurantServiceProvider.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantServiceProvider.ServiceRepository
{
    public class UserServiceRepository : IUserServiceRepository
    {
        private RestaurantServiceProviderContext db;


        public UserServiceRepository(RestaurantServiceProviderContext context)
        {
            db = context;
        }


        public void AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public List<Booking> GetAllBookingsGivenEmail(string email) => db.Users.Include(u => u.Bookings)
                                                                          .Where(u => u.Email == email).FirstOrDefault().Bookings.ToList();

        public List<User> GetAllUsers() => db.Users.ToList();
    }
}
