using System.Collections.Generic;
using System.Text;

namespace SimpleUrlBuilder
{
    public class QueryStringBuilder
    {
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        public QueryStringBuilder WithParam(string key, string value)
        {
            _parameters.Add(key, value);
            return this;
        }
        public string Build()
        {
            //TODO: implement this
            return string.Empty;
        }
    }
}