using System;
using Xunit;

namespace HtmlDocument.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //var builder = new HtmlDocumentBuilder();
            //builder.AddHeader("X");
            //builder.AddParagraph("test");

            //var output = builder.Build();

            var output = new HtmlDocumentBuilder()
                .AddHeader("X")
                .AddParagraph("test 1")
                .AddParagraph("test 2")
                .AddParagraph("test 3")
                .Build();

            //Step-Builder  (Next-Session) !
        }
    }
}
