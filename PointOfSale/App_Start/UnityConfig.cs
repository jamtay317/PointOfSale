using PointOfSale.DataProvider.Users;
using PointOfSale.Services.Navigatoin;
using Prism.Ioc;

namespace PointOfSale
{
    public static class UnityConfig
    {
        public static IContainerRegistry RegisterSingletons(this IContainerRegistry registry)
        {
            
            registry.RegisterSingleton(typeof(IUserDataProvider),typeof(UserDataProvider));
            registry.RegisterSingleton(typeof(INavigationService), typeof(NavigationService));
            return registry;
        }

        public static IContainerRegistry RegisterInstances(this IContainerRegistry registry)
        {
            return registry;
        }
    }
}