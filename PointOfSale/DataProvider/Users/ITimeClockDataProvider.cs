using System.Threading.Tasks;

namespace PointOfSale.DataProvider.Users
{
    public interface ITimeClockDataProvider
    {
        Task ClockInAsync(string employeeNumber);

        Task ClockOutAsync(string employeeNumber);
    }
}