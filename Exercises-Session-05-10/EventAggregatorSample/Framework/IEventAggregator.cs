using System;

namespace EventAggregatorSample.Framework
{
    //Applying Interface-Segregation
    public interface IEventPublisher
    {
        public void Publish<T>(T @event) where T : IEvent;
    }

    public interface IEventSubscriber
    {
        public void Subscribe<T>(IEventHandler<T> handler) where T : IEvent;
        public void Subscribe<T>(Action<T> handler) where T : IEvent;
    }

    //public interface IEventAggregator
    //{
        
    //}
}