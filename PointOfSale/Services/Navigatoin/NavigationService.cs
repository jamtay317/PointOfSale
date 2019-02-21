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
        public void Navigate(string viewName)
        {
            _regionManager.RequestNavigate(Regions.MainRegion, viewName);
        }

        public void GoToLogin()
        {
            Navigate(Constants.Views.LoginView);
        }
    }
}