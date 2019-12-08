using RestaurantServiceProvider.Entities;
using System.Collections.Generic;

namespace RestaurantServiceProvider.ServiceRepository
{
    public interface IUserServiceRepository
    {
        public abstract void AddUser(User user);

        public abstract List<User> GetAllUsers();

        public abstract List<Booking> GetAllBookingsGivenEmail(string email);
    }
}
