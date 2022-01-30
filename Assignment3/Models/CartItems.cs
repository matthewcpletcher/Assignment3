using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3.Models
{
    public class CartItems
    {
        [Key]
        public int CartId {get; set;}
        [Required]
        [ForeignKey("Order")]
        public int OrderID {get; set;}
        [Required]
        [ForeignKey("OrderItem")]
        public int ProductId { get; set;}
        public int Quantity {get; set;}
        public string? ProductName {get; set;} 
    }
}



