namespace E_Commerce.Models
{
    public class Order
    {

        public Guid OrderId { get; set; }

        public Guid UserId { get; set; }

        public Guid ProductId { get; set; }

        public DateTime Orderdate { get; set; }

        public string OrderStatus { get; set; }

        public  decimal TotalAmount { get; set; }


        //public User User { get; set; }

        //public Product Product { get; set; }

    }
}
