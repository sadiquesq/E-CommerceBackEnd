namespace E_Commerce.Models
{
    public class Cart
    {

        public Guid CartId { get; set; }

        public Guid UserId { get; set; }

        public decimal TotalAmount { get; set; }

        public User User { get; set; }
    }
}
