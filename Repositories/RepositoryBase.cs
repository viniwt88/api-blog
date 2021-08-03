using blogApi.DbContext;
using blogApi.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace blogApi.Repositories
{
    public class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class
    {
        protected readonly BlogContext Context;
        protected readonly DbSet<T> DbSet;

        public RepositoryBase(BlogContext context, DbSet<T> dbSet)
        {
            Context = context;
            DbSet = dbSet;
        }


        // ações do CRUD genéricas

        public virtual void Add(T entity) => DbSet.Add(entity);

        public virtual void Delete(int id) => DbSet.Remove(DbSet.Find(id));

        public virtual T GetById(int id) => DbSet.Find(id);

        public virtual IEnumerable<T> GetAll() => DbSet.AsNoTracking().ToList();

        public int Commit() => Context.SaveChanges();

        public void Update(T entity)
        {
            var entry = Context.Entry(entity);

            var keyName = Context.Model
                .FindEntityType(typeof(T))
                .FindPrimaryKey()
                .Properties.Select(x => x.Name)
                .Single();

            // ReSharper disable once PossibleNullReferenceException
            long pkey = (long)entity.GetType().GetProperty(keyName).GetValue(entity);

            if (entry.State == EntityState.Detached)
            {
                T attachedEntity = Context.Set<T>().Find(pkey);

                if (attachedEntity != null)
                {
                    var attachedEntry = Context.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(entity);

                    DbSet.Update(attachedEntity);
                }
                else
                {
                    DbSet.Update(entity);
                }
            }
        }

        public void Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
