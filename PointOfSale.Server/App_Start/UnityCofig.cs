using PointOfSale.Data.Database.Context;
using PointOfSale.Data.Repository;
using Unity;

namespace PointOfSale.Server
{
    public static class UnityCofig
    {
        public static IUnityContainer RegisterSingletons(this IUnityContainer container)
        {
            container.RegisterType<IDbContext, ApplicationDbContext>();
            return container;
        }

        public static IUnityContainer RegisterInstances(this IUnityContainer container)
        {
            container.RegisterType(typeof(ILookupRepository<>), typeof(LookupRepository<>));
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>));
            
            return container;
        }
    }
}