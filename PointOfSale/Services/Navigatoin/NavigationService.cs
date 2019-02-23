using System.Linq;
using PointOfSale.Constants;
using Prism.Regions;

namespace PointOfSale.Services.Navigatoin
{
    public class NavigationService:INavigationService
    {
        private readonly IRegionManager _regionManager;

        public NavigationService(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void NavigateToAdmin(string viewName, params (string name, object value)[] parameters)
        {
            Navigate(Regions.AdminRegion, viewName, parameters);
        }

        public void Navigate(string viewName, params (string name, object value)[] parameters)
        {
            Navigate(Regions.MainRegion, viewName, parameters);
        }

        private void Navigate(string regionName, string viewName, params (string name, object value)[] parameters)
        {
            var navaigationParams = GetParameters(parameters);
            _regionManager.RequestNavigate(regionName, viewName, navaigationParams);
        }

        private static NavigationParameters GetParameters((string name, object value)[] parameters)
        {
            var navaigationParams = new NavigationParameters();

            foreach (var parameter in parameters)
            {
                navaigationParams.Add(parameter.name, parameter.value);
            }

            return navaigationParams;
        }

        public void GoToLogin()
        {
            Navigate(Constants.Views.LoginView);
        }

        public void RemoveViewFromAdmin()
        {
            var regionViews =_regionManager.Regions[Regions.AdminRegion].ActiveViews;
            _regionManager.Regions[Regions.AdminRegion].Remove(regionViews.First());
        }
    }
}