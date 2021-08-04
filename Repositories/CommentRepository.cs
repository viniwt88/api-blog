using blogApi.DbContext;
using blogApi.Interfaces.Repositories;
using blogApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace blogApi.Repositories
{
    public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(BlogContext context, DbSet<Comment> dbSet) : base(context, dbSet)
        {
        }

        public void Add(Comment entity)
        {
        }

        public void Delete(int id)
        {
        }

        public Comment GetById(int id)
        {
            return null;
        }

        public IEnumerable<Comment> GetAll()
        {
            yield break;
        }

        public int Commit()
        {
            return 1;
        }

        public void Update(Comment entity)
        {
        }
    }
}
