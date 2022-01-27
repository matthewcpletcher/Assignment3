using System.ComponentModel.DataAnnotations;
namespace Assignment3.Models
{
    public class Store
    {
        [Key]
        public int StoreID { get; set; }
        public string? StoreName { get; set; }
        public string? Address { get; set; }
    }
}