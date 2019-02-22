using System.Data.Entity;
using PointOfSale.Models;

namespace PointOfSale.Data.Database.Context
{
    public class ApplicationDbContext:DbContext,IDbContext
    {

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<MenuItem> MenuItems { get; set; }

        public void SetValues<TEntity>(ref TEntity databaseValues, ref TEntity newValues)
            where TEntity : class,new()
        {
            Entry(databaseValues).CurrentValues.SetValues(newValues);
        }
    }
}