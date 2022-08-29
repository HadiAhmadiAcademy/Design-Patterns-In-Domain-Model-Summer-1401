using System.Net.Http;

namespace RestLibrary
{
    public interface IHttpRequestBuilder
    {
        IHttpRequestBuilder Url(string url);
        HttpRequestMessage Build();
    }
}