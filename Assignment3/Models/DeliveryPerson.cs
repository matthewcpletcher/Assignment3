using System.ComponentModel.DataAnnotations;
namespace Assignment3.Models
{
    public class DeliveryPerson
    {
        [Key]
        public int DPersonID { get; set; }
        public string? Name { get; set; }
    }
}