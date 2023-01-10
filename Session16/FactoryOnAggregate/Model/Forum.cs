namespace FactoryOnAggregate.Model;

public class Forum          //AggregateRoot
{
    public long Id { get; set; }
    public long TenantId { get; set; }
    public bool IsOpen { get; set; }

    public Discussion StartDiscussion(string title, long authorId, string body)
    {
        if (this.IsOpen == false) throw new Exception();

        return new Discussion(title, authorId, body, this.TenantId, this.Id);
    }
}