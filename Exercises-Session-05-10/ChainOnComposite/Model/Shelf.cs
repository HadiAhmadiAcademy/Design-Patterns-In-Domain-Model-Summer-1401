using System;
using System.Collections.Generic;
using System.Linq;
using ChainOnComposite.Visitors;

namespace ChainOnComposite.Model
{
    public class Shelf : Container
    {
        private List<Container> _innerContainers;
        public IReadOnlyList<Container> InnerContainers => _innerContainers;
        public Shelf()
        {
            _innerContainers = new List<Container>();    
        }
        public override long TotalCapacity()
        {
            return _innerContainers.Sum(a => a.TotalCapacity());
        }
        public override long UsedCapacity()
        {
            return _innerContainers.Sum(a => a.UsedCapacity());
        }

        public void AddContainer(params Container[] container)
        {
            _innerContainers.AddRange(container);
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override Liquid Fill(Liquid liquid)
        {
            foreach (var child in _innerContainers)
            {
                liquid = child.Fill(liquid);
                if (liquid.Amount == 0)
                    break;
            }
            return liquid;
        }
    }
}