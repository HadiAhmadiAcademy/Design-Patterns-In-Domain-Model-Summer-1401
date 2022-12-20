namespace SA.Domain.Framework
{
    public interface IAggregateRoot
    {
        IReadOnlyList<IDomainEvent> UncommittedEvents { get; }
    }
}