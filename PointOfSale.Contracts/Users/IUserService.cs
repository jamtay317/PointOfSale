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
    }
}