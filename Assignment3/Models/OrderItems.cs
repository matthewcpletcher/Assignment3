using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Assignment3.Models
{
    public class OrderItem
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }

    }
}
