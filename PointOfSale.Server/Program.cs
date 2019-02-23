using System;
using PointOfSale.Contracts.Menu;
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
            Console.WriteLine("UsersService hosted on http://localhost:8080/users");

            var menuServiceHost = new UnityServiceHost(container, typeof(MenuService));
            menuServiceHost.Open();
            Console.WriteLine("MenuService hosted on http://localhost:8080/menu");

            Console.WriteLine("Press <Enter> To Exit");
            Console.ReadLine();
        }
    }
}
