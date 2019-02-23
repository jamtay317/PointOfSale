using PointOfSale.DataProvider.Menu;
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
            registry.RegisterSingleton(typeof(ITimeClockDataProvider), typeof(TimeClockDataProvider));
            registry.RegisterSingleton(typeof(IMenuDataProvider), typeof(MenuDataProvider));
            return registry;
        }

        public static IContainerRegistry RegisterInstances(this IContainerRegistry registry)
        {
            return registry;
        }
    }
}