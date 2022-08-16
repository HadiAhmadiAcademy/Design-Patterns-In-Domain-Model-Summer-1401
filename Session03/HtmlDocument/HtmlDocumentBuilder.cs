using System;

namespace HtmlDocument
{
    public class HtmlDocumentBuilder
    {
        public HtmlDocumentBuilder AddHeader(string header)
        {
            //...
            return this;
        }
        public HtmlDocumentBuilder AddParagraph(string content)
        {
            //...
            return this;
        }
        public HtmlDocumentBuilder AddTable(string content)
        {
            //...
            return this;
        }

        public string Build()
        {
            return null;
        }
    }
}
