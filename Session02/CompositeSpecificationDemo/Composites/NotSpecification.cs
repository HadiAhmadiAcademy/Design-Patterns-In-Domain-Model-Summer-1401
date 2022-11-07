namespace CompositeSpecificationDemo.Composites
{
    public class NotSpecification<T> : Specification<T>
    {
        private readonly Specification<T> _targetSpec;

        public NotSpecification(Specification<T> targetSpec)
        {
            _targetSpec = targetSpec;
        }

        public override bool IsSatisfiedBy(T entity)
        {
            return !_targetSpec.IsSatisfiedBy(entity);
        }

        public override void Accept(ISpecificationVisitor<T> visitor)
        {
            visitor.Visit(this);
            visitor.PrepareToVisitLeftOperand();
            _targetSpec.Accept(visitor);
        }
    }
}