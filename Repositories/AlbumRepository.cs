using blogApi.Interfaces.Repositories;
using blogApi.Models;
using System.Collections.Generic;
using blogApi.DbContext;
using Microsoft.EntityFrameworkCore;

namespace blogApi.Repositories
{
    public class AlbumRepository : RepositoryBase<Album>, IAlbumRepository
    {
        public AlbumRepository(BlogContext context, DbSet<Album> dbSet) : base(context, dbSet)
        {
        }

        public void Add(Album entity)
        {
        }

        public void Delete(int id)
        {
        }

        public Album GetById(int id)
        {
            return null;
        }

        public IEnumerable<Album> GetAll()
        {
            yield break;
        }

        public int Commit()
        {
            return 1;
        }

        public void Update(Album entity)
        {
        }
    }
}
