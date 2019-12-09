using RestaurantServiceProvider.DTO;
using RestaurantServiceProvider.Entities;
using RestaurantServiceProvider.ServiceRepository;
using System.Collections.Generic;


namespace RestaurantServiceProvider.Service
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;   
        }

        public void AddUser(UserDTO userDTO)
        {
            _userRepository.AddUser(Entities.User.Create(userDTO));
        }

        public List<Booking> GetAllBookingsGivenEmail(string email)
        {
            return _userRepository.GetAllBookingsGivenEmail(email);
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
    }
}
