using blogApi.Interfaces.Repositories;
using blogApi.Models;
using System.Collections.Generic;
using blogApi.DbContext;
using Microsoft.EntityFrameworkCore;

namespace blogApi.Repositories
{
    public class PostRepository :  RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(BlogContext context, DbSet<Post> dbSet) : base(context, dbSet)
        {
        }
    }
}
