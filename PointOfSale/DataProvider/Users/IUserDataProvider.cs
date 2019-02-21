using System.Threading.Tasks;
using PointOfSale.Contracts.Users;
using PointOfSale.UsersService;

namespace PointOfSale.DataProvider.Users
{
    public interface IUserDataProvider
    {
        Task<User[]> GetClockedInUsers();

        Task<LoginStatus> GetLoginInfoAsync(string username, string password);
    }
}