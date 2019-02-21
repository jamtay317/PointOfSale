namespace PointOfSale.Services.Navigatoin
{
    public interface INavigationService
    {
        void Navigate(string viewName, params  (string name, object value)[] parameters);

        void GoToLogin();
    }
}