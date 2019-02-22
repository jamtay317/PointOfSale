using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using PointOfSale.Contracts.Users;
using PointOfSale.Server.ServiceHosts;
using Unity;

namespace PointOfSale.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterSingletons().RegisterInstances();

            var usersServiceHost = new UnityServiceHost(container, typeof(UsersService));
            usersServiceHost.Open();
            Console.WriteLine($"UsersService hosted on http://localhost:8080/users");

            Console.ReadLine();
        }
    }
}
