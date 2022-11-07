﻿using CompositeSpecificationDemo.Composites;

namespace CompositeSpecificationDemo.Leafs
{
    public class IsZeroSpecification : Specification<long>
    {
        public override bool IsSatisfiedBy(long entity)
        {
            return entity == 0;
        }
        
        public override void Accept(ISpecificationVisitor<long> visitor)
        {
            visitor.Visit(this);
        }
    }
}