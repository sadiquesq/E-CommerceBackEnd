using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Product
    {
        public Guid ProductId { get; set; } 

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public int stock { get; set; }
      
        public Guid CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<CartItem> cartItem { get; set; }

        public ICollection<Order> orders { get; set; }
    }
}
