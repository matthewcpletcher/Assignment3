using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3.Models
{
    public class Cart
    {
        [Key]
        public int CartId {get; set;}
        [Required]
        [ForeignKey("OrderItems")]
        public int ProductID {get; set;}
        public int Quantity {get; set;}

        public string? ProductName {get; set;}
        

    }
}



