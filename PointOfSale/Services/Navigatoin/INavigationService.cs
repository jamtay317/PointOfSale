namespace PointOfSale.Services.Navigatoin
{
    public interface INavigationService
    {
        void Navigate(string viewName);
        void GoToLogin();
    }
}