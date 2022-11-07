using System;
using CompositeSpecificationDemo.Leafs;
using CompositeSpecificationDemo.Visitors;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace CompositeSpecificationDemo.Tests
{
    public class ExcelExpressionGeneratorSpecificationVisitorTests : IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly ExcelExpressionGeneratorSpecificationVisitor<long> _visitor;

        public ExcelExpressionGeneratorSpecificationVisitorTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _visitor = new ExcelExpressionGeneratorSpecificationVisitor<long>();
        }

        [Fact]
        public void Test1()
        {
            var spec = new EvenNumbers().And(new PositiveNumbers()).Or(new IsZeroSpecification());
            spec.Accept(_visitor);
            _visitor.Expression.ShouldBe("OR ( AND ( MOD( A1 , 2 ) = 0 , A1 > 0 ) , A1 = 0 )");
        }

        [Fact]
        public void Test2()
        {
            var spec = new IsZeroSpecification().Or(new PositiveNumbers().And(new EvenNumbers()));
            spec.Accept(_visitor);
            _visitor.Expression.ShouldBe("OR ( A1 = 0 , AND ( A1 > 0 , MOD( A1 , 2 ) = 0 ) )");
        }

        [Fact]
        public void Test3()
        {
            var spec = new PositiveNumbers().And(new PositiveNumbers().And(new PositiveNumbers().And(new PositiveNumbers()))).Or(new EvenNumbers());
            spec.Accept(_visitor);
            _visitor.Expression.ShouldBe("OR ( AND ( A1 > 0 , AND ( A1 > 0 , AND ( A1 > 0 , A1 > 0 ) ) ) , MOD( A1 , 2 ) = 0 )");
        }

        [Fact]
        public void Test4()
        {
            var spec = new EvenNumbers().Or(new PositiveNumbers().And(new PositiveNumbers().And(new PositiveNumbers().And(new PositiveNumbers()))));
            spec.Accept(_visitor);
            _visitor.Expression.ShouldBe("OR ( MOD( A1 , 2 ) = 0 , AND ( A1 > 0 , AND ( A1 > 0 , AND ( A1 > 0 , A1 > 0 ) ) ) )");
        }

        [Fact]
        public void Test5()
        {
            var spec = new EvenNumbers().Or(new PositiveNumbers().Not());
            spec.Accept(_visitor);
            _visitor.Expression.ShouldBe("OR ( MOD( A1 , 2 ) = 0 , NOT ( A1 > 0 ) )");
        }

        private void PrintExpressionInTestResults(ExcelExpressionGeneratorSpecificationVisitor<long> visitor)
        {
            _testOutputHelper.WriteLine(visitor.Expression);
        }

        public void Dispose()
        {
            PrintExpressionInTestResults(_visitor);
        }
    }
}