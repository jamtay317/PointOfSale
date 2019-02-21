using System.Threading.Tasks;
using PointOfSale.DataProvider.Users;
using PointOfSale.Services.Navigatoin;
using PointOfSale.ViewModels.Bases;
using Prism.Commands;

namespace PointOfSale.ViewModels
{
    public class ClockInViewModel:ViewModelBase
    {
        private readonly ITimeClockDataProvider _clockInDataProvider;
        private readonly INavigationService _navigationService;

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
            await _clockInDataProvider.ClockInAsync(EmployeeNumber);

            _navigationService.Navigate(Constants.Views.LoginView);
        }


        private void OnKeypadCkicked(string obj)
        {
            EmployeeNumber += obj;
        }
    }
}