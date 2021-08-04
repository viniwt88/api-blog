using blogApi.Models;
using System.Threading.Tasks;

namespace blogApi.Interfaces.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<User> VerifyUser(string username, string password);
    }
}
