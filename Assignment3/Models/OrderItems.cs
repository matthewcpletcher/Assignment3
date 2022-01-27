using System.ComponentModel.DataAnnotations;
namespace Assignment3.Models
{
    public class OrderItems
    {
        [Key]
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }

    }
}