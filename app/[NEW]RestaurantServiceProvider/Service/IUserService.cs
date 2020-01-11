using RestaurantServiceProvider.DTO;
using RestaurantServiceProvider.Entities;
using System.Collections.Generic;


namespace RestaurantServiceProvider.Service
{
    public interface IUserService
    {
        public void AddUser(UserDTO userDTO);
        public List<Booking> GetAllBookingsGivenEmail(string email);
        public List<User> GetAllUsers();
    }
}
