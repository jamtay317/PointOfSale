using System.Collections.ObjectModel;
using PointOfSale.UsersService;
using PointOfSale.ViewModels.Bases;
using Prism.Commands;

namespace PointOfSale.ViewModels
{
    public class ShellViewModel:ViewModelBase
    {
        private readonly UserServiceClient _userServiceClient;
        public string Title { get; set; } = "Point Of Sale";

        public ShellViewModel()
        {
            _userServiceClient = new UserServiceClient();
            GetUsersCommand = new DelegateCommand(GetUsers);
            Users = new ObservableCollection<User>();
        }

        

        public DelegateCommand GetUsersCommand { get; set; }

        public ObservableCollection<User> Users { get; set; }


        private void GetUsers()
        {
            var users = _userServiceClient.GetClockedInUsers();
            Users.Clear();
            Users.AddRange(users);
        }
    }
}
