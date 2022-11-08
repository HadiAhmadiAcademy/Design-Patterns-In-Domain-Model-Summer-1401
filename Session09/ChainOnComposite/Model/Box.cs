using System.Collections.Generic;
using ChainOnComposite.Visitors;

namespace ChainOnComposite.Model
{
    public class Box : Container
    {
        private long _capacity;
        private List<Item> _items;
        public override IReadOnlyList<Item> Items => _items;
        public Box(long capacity)
        {
            _items = new List<Item>();
            _capacity = capacity;
        }
        public override long TotalCapacity() => _capacity;
        public override bool CanPutItem(Item item)
        {
            return RemainingCapacity() >= item.Size;
        }

        public override void PutItem(Item item)
        {
            if (CanPutItem(item))
                _items.Add(item);
            //.......
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

    }
}