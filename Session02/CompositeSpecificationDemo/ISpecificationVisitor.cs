using CompositeSpecificationDemo.Composites;
using CompositeSpecificationDemo.Leafs;

namespace CompositeSpecificationDemo
{
    public interface ISpecificationVisitor<T>
    {
        public void Visit(AndSpecification<T> andSpecification);
        public void Visit(OrSpecification<T> orSpecification);
        public void Visit(NotSpecification<T> notSpecification);
        public void Visit(IsZeroSpecification isZeroSpecification);
        public void Visit(EvenNumbers evenNumbers);
        public void Visit(PositiveNumbers positiveNumbers);
        public void PrepareToVisitRightOperand();
        public void PrepareToVisitLeftOperand();
    }
}