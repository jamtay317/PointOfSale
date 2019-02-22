using System;
using PointOfSale.Data.Database.Context;
using PointOfSale.Models;

namespace PointOfSale.Data.Repository
{
    public class Repository<T>:LookupRepository<T>, IRepository<T> 
        where T : class, IEntity, new()
    {
        public Repository(IDbContext context) : base(context)
        {
        }

        public T Post(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();

            return entity;
        }

        public T Put(T entity)
        {
            if (Get(entity.Id) is T databaseEntity)
            {
                Context.SetValues(ref databaseEntity, ref entity);
                Context.SaveChanges();
                return entity;
            }
            
            throw new InvalidOperationException("The Entity wasnt in the database");
            
        }

        public void Delete(int id)
        {
            if (Get(id) is T databaseEntity)
            {
                Context.Set<T>().Remove(databaseEntity);
                Context.SaveChanges();
                return;
            }

            throw new InvalidOperationException("The Entity wasnt in the database");
        }
    }
}