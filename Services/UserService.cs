using blogApi.Interfaces.Repositories;
using blogApi.Interfaces.Services;
using blogApi.Models;

namespace blogApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool CreateUser(User user)
        {
            _userRepository.Add(user);
            return _userRepository.Commit() > 0;
        }
    }
}
