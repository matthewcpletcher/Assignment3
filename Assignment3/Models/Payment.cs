using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Assignment3.Models
{
    public class Payment
    {
        [Required]
        [ForeignKey ("Customer")]
        public int CustomerID { get; set; }
        [Required]
        [ForeignKey ("Order")]
        public int OrderNumber { get; set; }
        public DateTime DatePayed { get; set; }
        public float Total { get; set; }
        
    }
}