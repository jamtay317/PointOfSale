using System.Linq;
using PointOfSale.Data.Database.Context;
using PointOfSale.Models;

namespace PointOfSale.Data.Repository
{
    public class LookupRepository<T>:ILookupRepository<T> where T:class,IEntity, new()
    {
        protected IDbContext Context { get; }

        public LookupRepository(IDbContext context)
        {
            Context = context;
        }

        public IQueryable<T> Get()
        {
            return Context.Set<T>();
        }

        public T Get(int id)
        {
            return Get().FirstOrDefault(entity => entity.Id == id);
        }
    }
}