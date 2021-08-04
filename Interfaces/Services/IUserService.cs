using blogApi.Models;

namespace blogApi.Interfaces.Services
{
    public interface IUserService
    {
        bool CreateUser(User user);
    }
}
