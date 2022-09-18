namespace BasketSample
{
    public interface IDiscountStrategy
    {
        long Calculate(long totalPrice);
    }

    public class VipCustomerOff : IDiscountStrategy
    {
        public long Calculate(long totalPrice)
        {
            return (long)(totalPrice  * 0.3);
        }
    }
}