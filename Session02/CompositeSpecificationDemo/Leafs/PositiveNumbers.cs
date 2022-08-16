using CompositeSpecificationDemo.Composites;

namespace CompositeSpecificationDemo.Leafs
{
    public class PositiveNumbers : Specification<long>
    {
        public override bool IsSatisfiedBy(long entity)
        {
            return entity > 0;
        }
    }
}