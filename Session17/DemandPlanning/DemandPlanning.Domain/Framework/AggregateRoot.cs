namespace DemandPlanning.Domain.Framework
{
    public class AggregateRoot<TKey> : Entity<TKey>, IAggregateRoot
    {
        private List<IDomainEvent> _uncommittedEvents;
        public IReadOnlyList<IDomainEvent> UncommittedEvents => _uncommittedEvents.AsReadOnly();
        public AggregateRoot()
        {
            _uncommittedEvents = new List<IDomainEvent>();
        }
    }
}