using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using PointOfSale.Contracts.Users;
using PointOfSale.DataProvider.Users;
using PointOfSale.Models;
using PointOfSale.Services.Navigatoin;
using PointOfSale.UsersService;
using PointOfSale.ViewModels.Bases;
using Prism.Commands;

namespace PointOfSale.ViewModels
{
    public class LoginViewModel:ViewModelBase
    {
        private readonly IUserDataProvider _userDataProvider;
        private readonly INavigationService _navigationService;

        public LoginViewModel(IUserDataProvider userDataProvider, INavigationService navigationService)
        {
            _userDataProvider = userDataProvider;
            _navigationService = navigationService;
        }

        public ObservableCollection<User> ClockedInUsers { get; set; }
        public DelegateCommand<string> KeypadClickedCommand { get; set; }
        public LoginModel LoginModel { get; set; } = new LoginModel();

        private User _selectedUser;
        public User SelectedUser
        {
            get => _selectedUser;
            set
            {
                SetProperty(ref _selectedUser, value);
                RaisePropertyChanged(nameof(IsUserSelected));
            }
        }

        public bool IsUserSelected => SelectedUser != null;
        

        protected override void RegisterCollections()
        {
            ClockedInUsers = new ObservableCollection<User>();
        }

        protected override void RegiserCommands()
        {
            KeypadClickedCommand = new DelegateCommand<string>(KeypadClicked);
        }

        protected override void RegisterEvents()
        {
            if(LoginModel==null) LoginModel = new LoginModel();
            LoginModel.PinTyped += async (s,e)=> await Login(s,e);
        }

        private async Task Login(object sender, string e)
        {
            var userLoginInfo = await _userDataProvider.GetLoginInfoAsync(SelectedUser.EmployeeNumber, LoginModel.ToString());
            switch (userLoginInfo)
            {
                case LoginStatus.InvalidLogin:
                    LoginModel.Clear();
                    break;
                case LoginStatus.ValidLogin:
                    //Navigate to Orders screen
                    _navigationService.Navigate(Constants.Views.OrdersView);
                    break;
                case LoginStatus.NeedsClockedIn:
                    LoginModel.Clear();
                    //alert not clocked in
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected override async void GetData()
        {
            var clockedInUsers = await _userDataProvider.GetClockedInUsers();
            ClockedInUsers.AddRange(clockedInUsers);
        }

        private void KeypadClicked(string content)
        {
            if (int.TryParse(content, out var value))
            {
                this.LoginModel.AddNextNumber(value);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}