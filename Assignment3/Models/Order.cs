using System.ComponentModel.DataAnnotations;
namespace Assignment3.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int DPersonID { get; set; }
        public int StoreId { get; set; }
        public int OrderStatus { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}