using System.ComponentModel.DataAnnotations;

namespace E_Commerce.DTOs.ProductDTO
{
    public class ProductDTO
    {
        [Required]
        public string ProductName { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int stock { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

    }
}
