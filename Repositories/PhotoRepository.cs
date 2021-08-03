using System.Collections.Generic;
using blogApi.Interfaces.Repositories;
using blogApi.Models;

namespace blogApi.Repositories
{
    public class PhotoRepository : IPhotoRepository, IRepositoryBase<Photo>
    {
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
