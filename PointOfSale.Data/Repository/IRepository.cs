using PointOfSale.Models;

namespace PointOfSale.Data.Repository
{
    public interface IRepository<T>:ILookupRepository<T>
        where T:class ,IEntity, new()
    {
        T Post(T entity);

        T Put(T entity);

        void Delete(int id);
    }
}