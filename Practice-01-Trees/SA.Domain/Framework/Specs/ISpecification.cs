namespace SA.Domain.Framework.Specs
{
    public interface ISpecification<T>
    {
        public bool IsSatisfiedBy(T entity);
    }
}
