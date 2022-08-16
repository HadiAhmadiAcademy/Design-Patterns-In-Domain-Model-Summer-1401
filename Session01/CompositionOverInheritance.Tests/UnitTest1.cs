using System;
using CompositionOverInheritance.Composition;
using CompositionOverInheritance.Inheritance;
using Xunit;

namespace CompositionOverInheritance.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var serializer = new CompressingXmlSerializerV2(
                        new EncodingXmlSerializerV2(
                            new XmlSerializerV2()));

        }
    }
}
