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
        public void Navigate(string viewName, params (string name, object value)[] parameters)
        {
            var navaigationParams = new NavigationParameters();

            foreach (var parameter in parameters)
            {
                navaigationParams.Add(parameter.name, parameter.value);
            }
            _regionManager.RequestNavigate(Regions.MainRegion, viewName, navaigationParams);
        }

        public void GoToLogin()
        {
            Navigate(Constants.Views.LoginView);
        }
    }
}