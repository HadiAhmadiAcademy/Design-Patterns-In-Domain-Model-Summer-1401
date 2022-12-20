namespace EventAggregatorSample.Framework
{
    public interface IEventHandler<T> where T : IEvent
    {
        void Handle(T @event);
    }
}