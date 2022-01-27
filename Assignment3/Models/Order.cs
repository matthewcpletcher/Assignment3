using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Assignment3.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        [Required]
        [ForeignKey ("Customer")]
        public int CustomerID { get; set; }
        [ForeignKey ("DeliveryPerson")]
        public int DPersonID { get; set; }
        [ForeignKey ("Store")]
        public int StoreId { get; set; }
        public int OrderStatus { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}