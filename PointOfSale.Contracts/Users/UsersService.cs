using System.Collections.Generic;
using System.Linq;
using PointOfSale.Data.Fake;
using PointOfSale.Data.Repository;
using PointOfSale.Models;

namespace PointOfSale.Contracts.Users
{
    public class UsersService:IUserService
    {
        private readonly ILookupRepository<User> _usersRepostory;
        public UsersService()
        {
            _usersRepostory = new UsersRepository();
        }
        public ICollection<User> GetClockedInUsers()
        {
            return _usersRepostory.Get().Where(user => user.IsClockedIn).ToList();
        }

        public LoginStatus Login(string employeeNumber, string password)
        {
            var clockedInUsers = GetClockedInUsers();
            if (!clockedInUsers.Any(user => employeeNumber == user.EmployeeNumber))
                return LoginStatus.NeedsClockedIn;

            var clockedInUser = clockedInUsers.Single(user => user.EmployeeNumber == employeeNumber);

            return clockedInUser.Password == password ?
                LoginStatus.ValidLogin : 
                LoginStatus.InvalidLogin;
        }

        public void ClockIn(string employeeNumber)
        {
            var user =_usersRepostory.Get().Single(x => x.EmployeeNumber == employeeNumber);
            user.IsClockedIn = true;
        }

        public void ClockOut(string employeeNumber)
        {
            var user = _usersRepostory.Get().Single(x => x.EmployeeNumber == employeeNumber);
            user.IsClockedIn = false;
        }
    }
}
