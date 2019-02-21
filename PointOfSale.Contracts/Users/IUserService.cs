using System.Collections.Generic;
using System.ServiceModel;
using PointOfSale.Models;

namespace PointOfSale.Contracts.Users
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        ICollection<User> GetClockedInUsers();

        [OperationContract]
        LoginStatus Login(string username, string password);

        [OperationContract]
        void ClockIn(string employeeNumber);

        [OperationContract]
        void ClockOut(string employeeNumber);
    }
}