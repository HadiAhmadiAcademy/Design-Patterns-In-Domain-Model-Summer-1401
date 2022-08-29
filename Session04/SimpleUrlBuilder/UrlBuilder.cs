using System;
using System.Collections.Generic;

namespace SimpleUrlBuilder
{
    public class UrlBuilder
    {
        private string _scheme = "http";
        private string _host = "localhost";
        private string _port = string.Empty;
        private QueryStringBuilder _queryStringBuilder;

        public UrlBuilder WithScheme(string scheme)
        {
            this._scheme = scheme;
            return this;
        }
        public UrlBuilder WithHost(string host)
        {
            this._host = host;
            return this;
        }
        public UrlBuilder WithPort(int port)
        {
            this._port = $":{port}";
            return this;
        }
        public UrlBuilder WithQueryString(Action<QueryStringBuilder> builderConfigurator)
        {
            var builder = new QueryStringBuilder();
            builderConfigurator.Invoke(builder);
            this._queryStringBuilder = builder;
            return this;
        }
        public string Build()
        {
            var queryString = this._queryStringBuilder?.Build();
            return $"{_scheme}://{_host}{_port}/{queryString}";
        }
    }
}