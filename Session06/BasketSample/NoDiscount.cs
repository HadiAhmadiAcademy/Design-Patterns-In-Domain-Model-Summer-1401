namespace BasketSample
{
    // Null Strategy
    public class NoDiscount : IDiscountStrategy
    {
        public static IDiscountStrategy Instance;
        static NoDiscount()
        {
            Instance = new NoDiscount();
        }
        private NoDiscount() { }
        public long Calculate(long totalPrice)
        {
            return 0;
        }
    }
}