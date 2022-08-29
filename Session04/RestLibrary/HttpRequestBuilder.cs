using System;
using System.Net.Http;

namespace RestLibrary
{
    public static class HttpRequestFactory
    {
        public static IHttpRequestMethodBuilder NewRequest()
        {
            return new HttpRequestBuilder();
        }
    }

    internal class HttpRequestBuilder : IHttpRequestBuilder,
                                        IHttpRequestMethodBuilder,
                                        IHttpRequestContentBuilder
    {
        private string _url = string.Empty;
        private string _content = string.Empty;
        private HttpMethod _method = HttpMethod.Get;
        internal HttpRequestBuilder() { }
        //public static IHttpRequestMethodBuilder NewRequest()
        //{
        //    return new HttpRequestBuilder();
        //}

        public IHttpRequestBuilder Url(string url)
        {
            this._url = url;
            return this;
        }
        
        public IHttpRequestBuilder Get()
        {
            return this;
        }
        public IHttpRequestContentBuilder Post()
        {
            return this;
        }
        public IHttpRequestContentBuilder Put()
        {
            return this;
        }

        public IHttpRequestBuilder WithBody(string body)
        {
            return this;
        }
        public HttpRequestMessage Build()
        {
            throw new NotImplementedException();
        }
    }
}
