namespace SA.Domain.Framework
{
    public class DomainEvent : IDomainEvent
    {
        public Guid EventId { get; }
        public DateTime PublishDateTime { get;  }
        public DomainEvent()
        {
            EventId = Guid.NewGuid();
            PublishDateTime = DateTime.Now;
        }
    }
}