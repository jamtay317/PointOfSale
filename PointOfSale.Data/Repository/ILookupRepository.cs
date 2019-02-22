using System.Collections.Generic;
using System.Linq;
using PointOfSale.Models;

namespace PointOfSale.Data.Repository
{
    public interface ILookupRepository<T> where T:class, IEntity
    {
        /// <summary>
        /// returns the query of t
        /// </summary>
        /// <returns></returns>
        IQueryable<T> Get();

        /// <summary>
        /// returns single item that matchs the default
        /// if not in database will return null
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Get(int id);
    }
}
