using System;

namespace BasketSample
{
    public class Basket
    {
        //....
        //....
        public DateTime CreateDateTime { get; private set; }
        public long TotalPrice { get; private set; }
        //...
        //...
        public void ApplyDiscount(IDiscountStrategy strategy)
        {
            //....
            //....
            // if (strategy != null)
            this.TotalPrice -= strategy.Calculate(this.TotalPrice);
            //....
            //....
        }
        public void ApplyDiscount()
        {
            ApplyDiscount(NoDiscount.Instance);
        }
    }
}
