using SpecificationTranslator.Visitors;

namespace SpecificationTranslator.Specifications.Composites
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T entity);
        void Accept(IVisitor visitor);

    }
}