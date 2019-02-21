using System.Collections.Generic;
using PointOfSale.Models;

namespace PointOfSale.Data.Repository
{
    public interface ILookupRepository<T> where T:class, IEntity
    {
        ICollection<T> Get();
        T Get(int id);
    }
}
