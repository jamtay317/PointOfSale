using System.Threading.Tasks;
using PointOfSale.Contracts.Users;
using PointOfSale.UsersService;
using IUserService = PointOfSale.UsersService.IUserService;

namespace PointOfSale.DataProvider.Users
{
    public class UserDataProvider:IUserDataProvider
    {
        private readonly IUserService _userServiceClient;

        public UserDataProvider()
        {
            _userServiceClient = new UserServiceClient();
        }

        public Task<User[]> GetClockedInUsers()
        {
            return _userServiceClient.GetClockedInUsersAsync();
        }

        public Task<LoginStatus> GetLoginInfoAsync(string username, string password)
        {
            return _userServiceClient.LoginAsync(username, password);
        }
    }
}