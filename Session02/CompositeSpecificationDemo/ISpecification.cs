namespace CompositeSpecificationDemo
{
    public interface ISpecification<T>
    {
        public bool IsSatisfiedBy(T entity);
    }
}
