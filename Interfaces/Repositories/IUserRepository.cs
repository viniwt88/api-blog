using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blogApi.Models;

namespace blogApi.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUser(string username, string password);
        bool CreateUser(User user);
    }
}
