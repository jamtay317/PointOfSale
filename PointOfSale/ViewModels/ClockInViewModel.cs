using System.Security;
using System.Threading.Tasks;
using System.Windows.Media.Converters;
using PointOfSale.DataProvider.Users;
using PointOfSale.Services.Navigatoin;
using PointOfSale.ViewModels.Bases;
using Prism.Commands;
using Prism.Regions;

namespace PointOfSale.ViewModels
{
    public class ClockInViewModel:ViewModelBase
    {
        private readonly ITimeClockDataProvider _clockInDataProvider;
        private readonly INavigationService _navigationService;

        private bool _isClockOut;

        public ClockInViewModel(ITimeClockDataProvider clockInDataProvider, INavigationService navigationService)
        {
            _clockInDataProvider = clockInDataProvider;
            _navigationService = navigationService;
        }
        public DelegateCommand<string> KeypadClickedCommand { get; set; }
        public DelegateCommand ClockInCommand { get; set; }

        private string _employeeNumber;
        public string EmployeeNumber
        {
            get => _employeeNumber;
            set => SetProperty(ref _employeeNumber, value);
        }

        protected override void RegiserCommands()
        {
            KeypadClickedCommand = new DelegateCommand<string>(OnKeypadCkicked);
            ClockInCommand = new DelegateCommand(async ()=> OnClockIn());
        }

        private async Task OnClockIn()
        {
            if (_isClockOut)
                await _clockInDataProvider.ClockOutAsync(EmployeeNumber);
            else
                await _clockInDataProvider.ClockInAsync(EmployeeNumber);

            _navigationService.Navigate(Constants.Views.LoginView);
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            var clockoutParam = navigationContext.Parameters["clockout"] as bool?;

            _isClockOut = clockoutParam.HasValue && clockoutParam.Value;
        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            _isClockOut = false;
            EmployeeNumber = string.Empty;
        }

        private void OnKeypadCkicked(string obj)
        {
            EmployeeNumber += obj;
        }
    }
}