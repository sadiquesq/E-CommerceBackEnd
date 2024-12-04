﻿namespace E_Commerce.Models
{
    public class Payment
    {
        public int Amount { get; set; }
        public string Currency { get; set; }
        public string Receipt { get; set; }
    }

    public class PaymentVerificationRequest
    {
        public string PaymentId { get; set; }
        public string OrderId { get; set; }
        public string Signature { get; set; }
    }

    public class RazorpaySettings
    {
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
    }
    public class orderDetails
    {
        public string orderId { get; set; }
        public string amount { get; set; }
        public string currency { get; set; }
        public string Link { get; set; }
    }
}
