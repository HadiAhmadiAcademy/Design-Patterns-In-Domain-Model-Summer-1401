using System.Collections.Generic;
using System.Linq;
using ChainOnComposite.Visitors;

namespace ChainOnComposite.Model
{
    public class Shelf : Container
    {
        private List<Container> _innerContainers;
        public IReadOnlyList<Container> InnerContainers => _innerContainers;
        public override IReadOnlyList<Item> Items => _innerContainers.SelectMany(a => a.Items).ToList();
        public Shelf()
        {
            _innerContainers = new List<Container>();    
        }
        public override long TotalCapacity()
        {
            return _innerContainers.Sum(a => a.TotalCapacity());
        }
        public void AddContainer(params Container[] container)
        {
            _innerContainers.AddRange(container);
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
        public override bool CanPutItem(Item item)
        {
            return _innerContainers.Any(a => a.CanPutItem(item));
        }
        public override void PutItem(Item item)
        {
            var candidateContainer = _innerContainers.FirstOrDefault(a => a.CanPutItem(item));
            if (candidateContainer != null) 
                candidateContainer.PutItem(item);
        }
    }
}