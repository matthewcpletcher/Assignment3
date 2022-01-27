using System.ComponentModel.DataAnnotations;
namespace Assignment3.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? PhoneNum { get; set; }
        public string? Email { get; set; }

    }
}