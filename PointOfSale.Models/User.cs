namespace PointOfSale.Models
{
    public class User:ModelBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string EmployeeNumber { get; set; }

        public string Password { get; set; }

        public bool IsClockedIn { get; set; }
    }
}
