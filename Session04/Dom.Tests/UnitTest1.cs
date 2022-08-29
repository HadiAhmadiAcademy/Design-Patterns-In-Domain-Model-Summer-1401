using System;
using Xunit;

namespace Dom.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var node = new XmlDocumentBuilder("Root").WithAttribute("ng-class","show")
                                .AddChild("child1").WithAttribute("attr-1", "1020")
                                .AddSibling("child2").WithAttribute("attr-2","2030")
                            .Build();

            var output = node.Render();
        }
    }
}
