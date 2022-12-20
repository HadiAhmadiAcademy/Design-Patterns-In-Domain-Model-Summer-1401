using System;
using EventAggregatorSample.App;
using EventAggregatorSample.Framework;

namespace EventAggregatorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var aggregator = new SimpleEventAggregator();

            SubscribeToEvents(aggregator);

            PublishEvents(aggregator);

            Console.ReadLine();
        }

        private static void SubscribeToEvents(IEventSubscriber aggregator)
        {
            aggregator.Subscribe(new CustomerActivationHandler());
            aggregator.Subscribe(new CustomerDefinedHandler());
            aggregator.Subscribe<CustomerActivated>(a => Console.WriteLine("Reacting to event from inline handler"));
        }
        private static void PublishEvents(IEventPublisher aggregator)
        {
            aggregator.Publish(new CustomerActivated());
        }
    }
}
