using System;
using System.Collections.Generic;
using System.Linq;

namespace EventAggregatorSample.Framework
{
    public class SimpleEventAggregator : IEventPublisher, IEventSubscriber
    {
        private List<object> _handlers = new List<object>();
        public void Subscribe<T>(IEventHandler<T> handler) where T : IEvent
        {
            _handlers.Add(handler);
        }

        public void Subscribe<T>(Action<T> handler) where T : IEvent
        {
            _handlers.Add(new DelegatingHandler<T>(handler));
        }

        public void Publish<T>(T @event) where T : IEvent
        {
            var candidateHandlers = _handlers.OfType<IEventHandler<T>>().ToList();
            foreach (var candidateHandler in candidateHandlers)
                candidateHandler.Handle(@event);
        }
    }
}