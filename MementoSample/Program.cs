namespace MementoSample
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var timeline = new CustomerTimeline();
            var customer = new Customer("john","doe","");

            timeline.Add(customer.SaveSnapshot());
            customer.Restore(timeline.PeekLatest());
        }
    }
}