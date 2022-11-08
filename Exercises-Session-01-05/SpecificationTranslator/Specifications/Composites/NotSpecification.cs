using SpecificationTranslator.Visitors;

namespace SpecificationTranslator.Specifications.Composites
{
    public class NotSpecification<T> : Specification<T>
    {
        public readonly ISpecification<T> TargetSpec;
        public NotSpecification(ISpecification<T> targetSpec)
        {
            TargetSpec = targetSpec;
        }

        public override bool IsSatisfiedBy(T entity)
        {
            return !TargetSpec.IsSatisfiedBy(entity);
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}