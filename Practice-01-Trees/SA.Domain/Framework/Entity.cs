namespace SA.Domain.Framework
{
    public class Entity<TKey>
    {
        public TKey Id { get; protected set; }
    }
}