using System.Collections.Generic;
using blogApi.Interfaces.Repositories;
using blogApi.Models;

namespace blogApi.Repositories
{
    public class AlbumRepository : IAlbumRepository,  IRepositoryBase<Album>
    {
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
            return 0;
        }

        public void Update(Album entity)
        {
        }
    }
}
