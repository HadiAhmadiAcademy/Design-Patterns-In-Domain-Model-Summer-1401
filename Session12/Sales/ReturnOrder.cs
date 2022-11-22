using System;

namespace Sales
{
    public class ReturnOrder
    {
        public long PaymentTransactionId { get; set; }
        public decimal PricePaid { get; set; }
        public long PostageCost { get; set; }
        public long ProductId { get; set; }
        public long Quantity { get; set; }
        public CustomerType CustomerType { get; set; }
    }

    public enum CustomerType
    {
        Gold,
        Normal,
    }

    public class Transaction
    {
        public long ProductId { get; set; }
        public long Quantity { get; set; }
    }
}
