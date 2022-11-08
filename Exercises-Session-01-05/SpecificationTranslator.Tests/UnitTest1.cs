using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using SpecificationTranslator.Specifications.Leafs;
using SpecificationTranslator.Visitors;
using Xunit;

namespace SpecificationTranslator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void x()
        {
            var spec = new PositiveNumbers().And(new EvenNumbers().Not());
            var visitor = new PersianTranslator();

            spec.Accept(visitor);
            var text = visitor.GetPersianTranslate();

            text.Should().Be("(زوج نباشد و مثبت باشد)");
            
        }
    }
}
