namespace FactoryOnAggregate.Model;

public class Discussion     //AggregateRoot
{
    public string Title { get; private set; }
    public long AuthorId { get; private set; }
    public string Body { get; private set; }
    public long ForumId { get; private set; }
    public long TenantId { get; private set; }
    internal Discussion(string title, long authorId, string body, long tenantId, long forumId)
    {
        //if (title == string.Empty) throw();

        Title = title;
        AuthorId = authorId;
        Body = body;
        ForumId = forumId;
        TenantId = tenantId;
    }
}