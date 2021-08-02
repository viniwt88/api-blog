using blogApi.Interfaces.Repositories;
using blogApi.Interfaces.Services;
using blogApi.Models;

namespace blogApi.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        private PostService(IPostRepository postRepository) => _postRepository = postRepository;


        public bool RealizarPostagem(Post post)
        {
            return true;
        }
    }
}
