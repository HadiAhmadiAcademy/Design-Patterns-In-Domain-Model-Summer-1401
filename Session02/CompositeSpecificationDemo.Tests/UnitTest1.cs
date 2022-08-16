using System;
using System.ComponentModel;
using System.Linq.Expressions;
using CompositeSpecificationDemo.Leafs;
using Xunit;

namespace CompositeSpecificationDemo.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var rule = GetRules();
            
            var result = rule.IsSatisfiedBy(10);
        }
        private static ISpecification<long> GetRules()
        {
            //var positiveEvenNumber =  new AndSpecification<long>(
            //        new EvenNumbers(),
            //        new PositiveNumbers());
            //var zero = new IsZeroSpecification();
            //return new OrSpecification<long>(positiveEvenNumber, zero);

            var rule = new EvenNumbers().And(new PositiveNumbers());
            return rule.Or(new IsZeroSpecification());
        }
    }
}
