﻿using SpecificationTranslator.Specifications.Composites;
using SpecificationTranslator.Visitors;

namespace SpecificationTranslator.Specifications.Leafs
{
    public class IsZeroSpecification : Specification<long>
    {
        public override bool IsSatisfiedBy(long entity)
        {
            return entity == 0;
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}