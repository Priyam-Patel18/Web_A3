using System.ComponentModel.DataAnnotations;

namespace A3_Priyam.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public decimal Pricing { get; set; }

        [Required]
        public decimal ShippingCost { get; set; }
    }
}
