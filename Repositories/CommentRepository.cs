using System.Collections.Generic;
using blogApi.Interfaces.Repositories;
using blogApi.Models;

namespace blogApi.Repositories
{
    public class CommentRepository : ICommentRepository, IRepositoryBase<Comment>
    {
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
