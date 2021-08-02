using blogApi.Models;

namespace blogApi.Interfaces.Services
{
    public interface IPostService
    {
        bool RealizarPostagem(Post post);
    }
}
