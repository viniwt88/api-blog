using System.Collections.Generic;

namespace blogApi.Interfaces.Repositories
{

    public interface IRepositoryBase<T> where T : class
    {
        void Add(T entity);

        void Delete(int id);

        T GetById(int id);

        IEnumerable<T> GetAll();

        int Commit();

        public void Update(T entity);

    }
}
