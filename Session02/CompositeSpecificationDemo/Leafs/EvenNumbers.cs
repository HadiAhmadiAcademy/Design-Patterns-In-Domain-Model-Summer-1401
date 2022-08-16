using CompositeSpecificationDemo.Composites;

namespace CompositeSpecificationDemo.Leafs
{
    public class EvenNumbers : Specification<long>
    {
        public override bool IsSatisfiedBy(long entity)
        {
            return entity % 2 == 0;
        }
    }
}