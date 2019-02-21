using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using PointOfSale.Contracts.Users;

namespace PointOfSale.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = new Uri("http://localhost:8080/users");

            using (var serviceHost = new ServiceHost(typeof(UsersService), baseAddress))
            {
                var serviceMetadataBehavior = new ServiceMetadataBehavior();
                serviceMetadataBehavior.HttpGetEnabled = true;
                serviceMetadataBehavior.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                serviceHost.Description.Behaviors.Add((serviceMetadataBehavior));

                serviceHost.Open();

                Console.WriteLine("The service is ready at {0}", baseAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                serviceHost.Close();
            }
        }
    }
}
