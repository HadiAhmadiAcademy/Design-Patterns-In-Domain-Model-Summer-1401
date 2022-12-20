using System;
using EventAggregatorSample.Framework;

namespace EventAggregatorSample.App
{
    public class CustomerDefinedHandler : IEventHandler<CustomerDefined>
    {
        public void Handle(CustomerDefined @event)
        {
            Console.WriteLine("Reacting to customer definition");
        }
    }
}