using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Threading.Tasks;

namespace PointOfSale.Data.Database.Context
{
    public interface IDbContext 
    {
        System.Data.Entity.Database Database { get; }
        IEnumerable<DbEntityValidationResult> GetValidationErrors();
        int SaveChanges();
        Task<int> SaveChangesAsync();
        DbSet Set(Type entityType);
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        void SetValues<TEntity>(ref TEntity databaseValues, ref TEntity newValues)
            where TEntity : class, new();
    }
}