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

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

    }
}
