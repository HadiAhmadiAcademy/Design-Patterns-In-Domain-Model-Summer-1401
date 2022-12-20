using System;
using EventAggregatorSample.Framework;

namespace EventAggregatorSample.App
{
    public class CustomerActivationHandler : IEventHandler<CustomerActivated>
    {
        public void Handle(CustomerActivated @event)
        {
            Console.WriteLine("Refreshing the grid of customers...");
        }
    }
}