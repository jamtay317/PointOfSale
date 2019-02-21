using PointOfSale.Services.Navigatoin;
using PointOfSale.ViewModels.Bases;
using Prism.Commands;

namespace PointOfSale.ViewModels
{
    public class ShellViewModel:ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public string Title { get; set; } = "Point Of Sale";

        public ShellViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public DelegateCommand LoadedCommand { get; set; }

        protected override void RegiserCommands()
        {
            LoadedCommand = new DelegateCommand(OnLoaded);
        }

        private void OnLoaded()
        {
            _navigationService.GoToLogin();
        }
    }
}
