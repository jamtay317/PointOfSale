using System.ComponentModel.DataAnnotations;

namespace PointOfSale.Models
{
    public class MenuItem:ModelBase
    {
        [StringLength(50), Required]
        public string Name { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}