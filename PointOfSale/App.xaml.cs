using Prism.Ioc;
using Prism.Unity;
using System.Windows;
using PointOfSale.App_Start;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry
                .RegisterSingletons()
                .RegisterInstances()
                .RegisterViews();
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<Views.Shell>();
        }

        
    }
}
