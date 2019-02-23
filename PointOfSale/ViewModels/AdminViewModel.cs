using PointOfSale.Services.Navigatoin;
using PointOfSale.ViewModels.Bases;
using Prism.Commands;

namespace PointOfSale.ViewModels
{
    public class AdminViewModel:ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public AdminViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public DelegateCommand<string> NavigateToAdminCommand { get; set; }
        public DelegateCommand NavigateToServerView { get; set; }

        protected override void RegiserCommands()
        {
            NavigateToAdminCommand = new DelegateCommand<string>(NavigateToAdmin);
            NavigateToServerView = new DelegateCommand(NavigateToServer);
        }

        private void NavigateToServer()
        {
            _navigationService.GoToLogin();
        }

        private void NavigateToAdmin(string viewName)
        {
            _navigationService.NavigateToAdmin(viewName);
        }
    }
}