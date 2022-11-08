using SpecificationTranslator.Specifications.Composites;
using SpecificationTranslator.Visitors;

namespace SpecificationTranslator.Specifications.Leafs
{
    public class EvenNumbers : Specification<long>
    {
        public override bool IsSatisfiedBy(long entity)
        {
            return entity % 2 == 0;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}