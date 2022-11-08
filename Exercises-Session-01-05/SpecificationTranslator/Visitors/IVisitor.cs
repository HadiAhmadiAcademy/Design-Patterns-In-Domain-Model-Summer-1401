using System.Linq.Expressions;
using SpecificationTranslator.Specifications.Composites;
using SpecificationTranslator.Specifications.Leafs;

namespace SpecificationTranslator.Visitors
{
    public interface IVisitor
    {
        void Visit<T>(AndSpecification<T> spec);
        void Visit<T>(OrSpecification<T> spec);
        void Visit<T>(NotSpecification<T> spec);
        void Visit(EvenNumbers spec);
        void Visit(IsZeroSpecification spec);
        void Visit(PositiveNumbers spec);
    }
}