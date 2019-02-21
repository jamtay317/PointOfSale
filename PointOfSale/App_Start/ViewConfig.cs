using Prism.Ioc;

namespace PointOfSale.App_Start
{
    public static class ViewConfig
    {
        public static IContainerRegistry RegisterViews(this IContainerRegistry registry)
        {
            registry.RegisterForNavigation<Views.LoginView>(Constants.Views.LoginView);
            registry.RegisterForNavigation<Views.OrdersView>(Constants.Views.OrdersView);

            return registry;
        }
    }
}
