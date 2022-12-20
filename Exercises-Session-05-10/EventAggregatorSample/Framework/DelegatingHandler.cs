using System;

namespace EventAggregatorSample.Framework
{
    public class DelegatingHandler<T> : IEventHandler<T> where T : IEvent
    {
        private readonly Action<T> _eventHandler;
        public DelegatingHandler(Action<T> eventHandler)
        {
            _eventHandler = eventHandler;
        }

        public void Handle(T @event)
        {
            _eventHandler.Invoke(@event);
        }
    }
}