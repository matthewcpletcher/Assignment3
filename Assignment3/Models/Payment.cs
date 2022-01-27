using System.ComponentModel.DataAnnotations;
namespace Assignment3.Models
{
    public class Payment
    {
        [Key]
        public int CustomerID { get; set; }
        public int OrderNumber { get; set; }
        public DateTime DatePayed { get; set; }
        public float Total { get; set; }
        
    }
}