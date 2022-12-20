namespace SA.Domain.Framework.Specs
{
    public class NotSpecification<T> : Specification<T>
    {
        private readonly ISpecification<T> _targetSpec;
        public NotSpecification(ISpecification<T> targetSpec)
        {
            _targetSpec = targetSpec;
        }

        public override bool IsSatisfiedBy(T entity)
        {
            return !_targetSpec.IsSatisfiedBy(entity);
        }
    }
}