namespace RestLibrary
{
    public interface IHttpRequestContentBuilder
    {
        IHttpRequestBuilder WithBody(string body);
    }
}