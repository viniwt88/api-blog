using blogApi.Interfaces.Repositories;
using blogApi.Models;
using System.Collections.Generic;
using blogApi.DbContext;
using Microsoft.EntityFrameworkCore;

namespace blogApi.Repositories
{
    public class PhotoRepository : RepositoryBase<Photo>, IPhotoRepository 
    {
        public PhotoRepository(BlogContext context, DbSet<Photo> dbSet) : base(context, dbSet)
        {
        }

        public void Add(Photo entity)
        {
        }

        public void Delete(int id)
        {
        }

        public Photo GetById(int id)
        {
            return null;
        }

        public IEnumerable<Photo> GetAll()
        {
            yield break;
        }

        public int Commit()
        {
            return 0;
        }

        public void Update(Photo entity)
        {
        }
    }
}
