using System;
using CompositeSpecificationDemo.Leafs;
using CompositeSpecificationDemo.Visitors;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace CompositeSpecificationDemo.Tests
{
    public class FarsiTextGeneratorSpecificationVisitorTests : IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly FarsiTextGeneratorSpecificationVisitor<long> _visitor;

        public FarsiTextGeneratorSpecificationVisitorTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _visitor = new FarsiTextGeneratorSpecificationVisitor<long>();
        }

        [Fact]
        public void Test1()
        {
            var spec = new EvenNumbers().And(new PositiveNumbers()).Or(new IsZeroSpecification());
            spec.Accept(_visitor);
            _visitor.Expression.ShouldBe("( ( الف زوج باشد ) و ( الف مثبت باشد ) ) یا ( الف صفر باشد )");
        }

        [Fact]
        public void Test2()
        {
            var spec = new IsZeroSpecification().Or(new PositiveNumbers().And(new EvenNumbers()));
            spec.Accept(_visitor);
            _visitor.Expression.ShouldBe("( الف صفر باشد ) یا ( ( الف مثبت باشد ) و ( الف زوج باشد ) )");
        }

        [Fact]
        public void Test3()
        {
            var spec = new PositiveNumbers().And(new PositiveNumbers().And(new PositiveNumbers().And(new PositiveNumbers()))).Or(new EvenNumbers());
            spec.Accept(_visitor);
            _visitor.Expression.ShouldBe("( ( الف مثبت باشد ) و ( ( الف مثبت باشد ) و ( ( الف مثبت باشد ) و ( الف مثبت باشد ) ) ) ) یا ( الف زوج باشد )");
        }

        [Fact]
        public void Test4()
        {
            var spec = new EvenNumbers().Or(new PositiveNumbers().And(new PositiveNumbers().And(new PositiveNumbers().And(new PositiveNumbers()))));
            spec.Accept(_visitor);
            _visitor.Expression.ShouldBe("( الف زوج باشد ) یا ( ( الف مثبت باشد ) و ( ( الف مثبت باشد ) و ( ( الف مثبت باشد ) و ( الف مثبت باشد ) ) ) )");
        }

        [Fact]
        public void Test5()
        {
            var spec = new EvenNumbers().Or(new PositiveNumbers().Not());
            spec.Accept(_visitor);
            _visitor.Expression.ShouldBe("( الف زوج باشد ) یا ( نباشد ( الف مثبت باشد ) )");
        }

        private void PrintExpressionInTestResults(FarsiTextGeneratorSpecificationVisitor<long> visitor)
        {
            _testOutputHelper.WriteLine(visitor.Expression);
        }

        public void Dispose()
        {
            PrintExpressionInTestResults(_visitor);
        }
    }
}