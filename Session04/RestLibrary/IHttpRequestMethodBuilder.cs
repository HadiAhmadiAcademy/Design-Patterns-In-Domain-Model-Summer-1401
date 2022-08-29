namespace RestLibrary
{
    public interface IHttpRequestMethodBuilder
    {
        IHttpRequestBuilder Get();
        IHttpRequestContentBuilder Post();
        IHttpRequestContentBuilder Put();
    }
}