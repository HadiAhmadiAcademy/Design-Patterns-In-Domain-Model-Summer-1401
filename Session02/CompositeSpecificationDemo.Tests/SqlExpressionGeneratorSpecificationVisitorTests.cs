using System;
using CompositeSpecificationDemo.Leafs;
using CompositeSpecificationDemo.Visitors;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace CompositeSpecificationDemo.Tests
{
    public class SqlExpressionGeneratorSpecificationVisitorTests : IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly SqlExpressionGeneratorSpecificationVisitor<long> _visitor;

        public SqlExpressionGeneratorSpecificationVisitorTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _visitor = new SqlExpressionGeneratorSpecificationVisitor<long>();
        }

        [Fact]
        public void Test1()
        {
            var spec = new EvenNumbers().And(new PositiveNumbers()).Or(new IsZeroSpecification());
            spec.Accept(_visitor);
            _visitor.Expression.ShouldBe("( ( x % 2 = 0 ) AND ( x > 0 ) ) OR ( x = 0 )");
        }

        [Fact]
        public void Test2()
        {
            var spec = new IsZeroSpecification().Or(new PositiveNumbers().And(new EvenNumbers()));
            spec.Accept(_visitor);
            _visitor.Expression.ShouldBe("( x = 0 ) OR ( ( x > 0 ) AND ( x % 2 = 0 ) )");
        }

        [Fact]
        public void Test3()
        {
            var spec = new PositiveNumbers().And(new PositiveNumbers().And(new PositiveNumbers().And(new PositiveNumbers()))).Or(new EvenNumbers());
            spec.Accept(_visitor);
            _visitor.Expression.ShouldBe("( ( x > 0 ) AND ( ( x > 0 ) AND ( ( x > 0 ) AND ( x > 0 ) ) ) ) OR ( x % 2 = 0 )");
        }

        [Fact]
        public void Test4()
        {
            var spec = new EvenNumbers().Or(new PositiveNumbers().And(new PositiveNumbers().And(new PositiveNumbers().And(new PositiveNumbers()))));
            spec.Accept(_visitor);
            _visitor.Expression.ShouldBe("( x % 2 = 0 ) OR ( ( x > 0 ) AND ( ( x > 0 ) AND ( ( x > 0 ) AND ( x > 0 ) ) ) )");
        }

        [Fact]
        public void Test5()
        {
            var spec = new EvenNumbers().Or(new PositiveNumbers().Not());
            spec.Accept(_visitor);
            _visitor.Expression.ShouldBe("( x % 2 = 0 ) OR ( NOT ( x > 0 ) )");
        }

        private void PrintExpressionInTestResults(SqlExpressionGeneratorSpecificationVisitor<long> visitor)
        {
            _testOutputHelper.WriteLine(visitor.Expression);
        }

        public void Dispose()
        {
            PrintExpressionInTestResults(_visitor);
        }
    }
}