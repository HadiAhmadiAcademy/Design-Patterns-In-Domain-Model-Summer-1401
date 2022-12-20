namespace SA.Domain.Framework.Specs
{
    public class OrSpecification<T> : Specification<T>
    {
        private readonly ISpecification<T> _leftSpec;
        private readonly ISpecification<T> _rightSpec;
        public OrSpecification(ISpecification<T> leftSpec, ISpecification<T> rightSpec)
        {
            _leftSpec = leftSpec;
            _rightSpec = rightSpec;
        }
        public override bool IsSatisfiedBy(T entity)
        {
            return _leftSpec.IsSatisfiedBy(entity) ||
                   _rightSpec.IsSatisfiedBy(entity);
        }
    }
}