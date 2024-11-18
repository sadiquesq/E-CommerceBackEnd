namespace E_Commerce.Models
{
    public class CartItem
    {
        public Guid CartItemId { get; set; }

        public int Quantity { get; set; }

        public Guid  UserId { get; set; }

        public Guid  CartId {  get; set; }

        //public User User { get; set; }
        //public Cart Cart { get; set; }
    }
}
