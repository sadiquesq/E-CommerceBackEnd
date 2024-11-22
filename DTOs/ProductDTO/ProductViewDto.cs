using System.ComponentModel.DataAnnotations;

namespace E_Commerce.DTOs.ProductDTO
{
    public class ProductViewDto
    {
        public Guid ProductId { get; set; }


        [Required]
        public string ProductName { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int stock { get; set; }
    }
}
