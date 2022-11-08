using SpecificationTranslator.Visitors;

namespace SpecificationTranslator.Specifications.Composites
{
    public class AndSpecification<T> : Specification<T>
    {
        public readonly ISpecification<T> LeftSpec;
        public readonly ISpecification<T> RightSpec;
        public AndSpecification(ISpecification<T> leftSpec, ISpecification<T> rightSpec)
        {
            LeftSpec = leftSpec;
            RightSpec = rightSpec;
        }
        public override bool IsSatisfiedBy(T entity)
        {
            return LeftSpec.IsSatisfiedBy(entity) &&
                   RightSpec.IsSatisfiedBy(entity);
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}