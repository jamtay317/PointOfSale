using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSale.Models
{
    [Table("Categories")]
    public class Category:ModelBase
    {
        [StringLength(50), Required]
        public string Name { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}