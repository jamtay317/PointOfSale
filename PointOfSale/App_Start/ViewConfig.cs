using Prism.Ioc;

namespace PointOfSale.App_Start
{
    public static class ViewConfig
    {
        public static IContainerRegistry RegisterViews(this IContainerRegistry registry)
        {
            registry.RegisterForNavigation<Views.LoginView>(Constants.Views.LoginView);
            registry.RegisterForNavigation<Views.OrdersView>(Constants.Views.OrdersView);
            registry.RegisterForNavigation<Views.ClockInView>(Constants.Views.ClockInView);
            registry.RegisterForNavigation<Views.AdminView>(Constants.Views.AdminView);
            registry.RegisterForNavigation<Views.CategoriesView>(Constants.Views.CategoriesView);

            return registry;
        }
    }
}
