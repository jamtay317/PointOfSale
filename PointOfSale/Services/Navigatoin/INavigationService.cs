namespace PointOfSale.Services.Navigatoin
{
    public interface INavigationService
    {
        void NavigateToAdmin(string viewName, params (string name, object value)[] parameters);

        void Navigate(string viewName, params  (string name, object value)[] parameters);

        void GoToLogin();

        void RemoveViewFromAdmin();
    }
}