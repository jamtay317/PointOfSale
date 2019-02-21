using System.Collections.Generic;
using System.Linq;
using PointOfSale.Data.Repository;
using PointOfSale.Models;

namespace PointOfSale.Data.Fake
{
    public class UsersRepository:ILookupRepository<User>
    {
        public ICollection<User> Get()
        {
            return new[]
            {
                new User() {FirstName = "Jon", LastName = "Doe", PhoneNumber = "(123) 456-7890", EmployeeNumber = "100", Password = "1234", IsClockedIn = false},
                new User() {FirstName = "Jane", LastName = "Doe", PhoneNumber = "(123) 567-8910", EmployeeNumber = "101", Password = "1234", IsClockedIn = true},
                new User() {FirstName = "Paul", LastName = "Smith", PhoneNumber = "(123) 789-1011", EmployeeNumber = "102", Password = "1234", IsClockedIn = true}
            };
        }

        public User Get(int id)
        {
            return Get().FirstOrDefault(user => user.Id == id);
        }
    }
}
