using System;
using CompositeSpecificationDemo.Leafs;
using CompositeSpecificationDemo.Visitors;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace CompositeSpecificationDemo.Tests
{
    public class EnglishTextGeneratorSpecificationVisitorTests : IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly EnglishTextGeneratorSpecificationVisitor<long> _visitor;

        public EnglishTextGeneratorSpecificationVisitorTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _visitor = new EnglishTextGeneratorSpecificationVisitor<long>();
        }

        [Fact]
        public void Test1()
        {
            var spec = new EvenNumbers().And(new PositiveNumbers()).Or(new IsZeroSpecification());
            spec.Accept(_visitor);
            _visitor.Expression.ShouldBe("( ( x is even ) AND ( x is positive ) ) OR ( x is zero )");
        }

        [Fact]
        public void Test2()
        {
            var spec = new IsZeroSpecification().Or(new PositiveNumbers().And(new EvenNumbers()));
            spec.Accept(_visitor);
            _visitor.Expression.ShouldBe("( x is zero ) OR ( ( x is positive ) AND ( x is even ) )");
        }

        [Fact]
        public void Test3()
        {
            var spec = new PositiveNumbers().And(new PositiveNumbers().And(new PositiveNumbers().And(new PositiveNumbers()))).Or(new EvenNumbers());
            spec.Accept(_visitor);
            _visitor.Expression.ShouldBe("( ( x is positive ) AND ( ( x is positive ) AND ( ( x is positive ) AND ( x is positive ) ) ) ) OR ( x is even )");
        }

        [Fact]
        public void Test4()
        {
            var spec = new EvenNumbers().Or(new PositiveNumbers().And(new PositiveNumbers().And(new PositiveNumbers().And(new PositiveNumbers()))));
            spec.Accept(_visitor);
            _visitor.Expression.ShouldBe("( x is even ) OR ( ( x is positive ) AND ( ( x is positive ) AND ( ( x is positive ) AND ( x is positive ) ) ) )");
        }

        [Fact]
        public void Test5()
        {
            var spec = new EvenNumbers().Or(new PositiveNumbers().Not());
            spec.Accept(_visitor);
            _visitor.Expression.ShouldBe("( x is even ) OR ( NOT ( x is positive ) )");
        }

        private void PrintExpressionInTestResults(EnglishTextGeneratorSpecificationVisitor<long> visitor)
        {
            _testOutputHelper.WriteLine(visitor.Expression);
        }

        public void Dispose()
        {
            PrintExpressionInTestResults(_visitor);
        }
    }
}