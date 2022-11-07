namespace CompositeSpecificationDemo.Composites
{
    public class OrSpecification<T> : Specification<T>
    {
        private readonly Specification<T> _leftSpec;
        private readonly Specification<T> _rightSpec;
        public OrSpecification(Specification<T> leftSpec, Specification<T> rightSpec)
        {
            _leftSpec = leftSpec;
            _rightSpec = rightSpec;
        }
        public override bool IsSatisfiedBy(T entity)
        {
            return _leftSpec.IsSatisfiedBy(entity) ||
                   _rightSpec.IsSatisfiedBy(entity);
        }

        public override void Accept(ISpecificationVisitor<T> visitor)
        {
            visitor.Visit(this);
            visitor.PrepareToVisitLeftOperand();
            _leftSpec.Accept(visitor);
            visitor.PrepareToVisitRightOperand();
            _rightSpec.Accept(visitor);
        }
    }
}