namespace SA.Domain.Framework.Specs
{
    public abstract class Specification<T> : ISpecification<T>
    {
        public Specification<T> And(ISpecification<T> right)
        {
            return new AndSpecification<T>(this, right);
        }
        public Specification<T> Or(ISpecification<T> right)
        {
            return new OrSpecification<T>(this, right);
        }
        public Specification<T> Not()
        {
            return new NotSpecification<T>(this);
        }

        public abstract bool IsSatisfiedBy(T entity);
    }
}