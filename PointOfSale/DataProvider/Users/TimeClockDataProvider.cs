using System.Threading.Tasks;
using PointOfSale.UsersService;

namespace PointOfSale.DataProvider.Users
{
    public class TimeClockDataProvider:ITimeClockDataProvider
    {
        private readonly UserServiceClient _userService;

        public TimeClockDataProvider()
        {
            _userService = new UserServiceClient();
        }
        public Task ClockInAsync(string employeeNumber)
        {
            return _userService.ClockInAsync(employeeNumber);
        }

        public Task ClockOutAsync(string employeeNumber)
        {
            return _userService.ClockOutAsync(employeeNumber);
        }
    }
}