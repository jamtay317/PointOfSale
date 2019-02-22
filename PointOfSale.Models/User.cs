using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSale.Models
{
    [Table("ApplicationUsers")]
    public class User:ModelBase
    {
        [StringLength(50), Required]
        public string FirstName { get; set; }

        [StringLength(50), Required]
        public string LastName { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(50), Required]
        public string EmployeeNumber { get; set; }

        [StringLength(50), Required]
        public string Password { get; set; }

        public bool IsClockedIn { get; set; }
    }
}
