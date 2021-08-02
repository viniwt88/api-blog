using blogApi.Models;

namespace blogApi.Interfaces.Services
{
    public interface ITokenService
    {
        public string GenerateToken(User user);
    }
}
