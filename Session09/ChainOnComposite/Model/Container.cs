using System.Collections.Generic;
using System.Linq;
using ChainOnComposite.Visitors;

namespace ChainOnComposite.Model
{
    public abstract class Container
    {
        public abstract IReadOnlyList<Item> Items { get; }
        public abstract long TotalCapacity();
        public long RemainingCapacity()
        {
            return TotalCapacity() - Items.Sum(a => a.Size);
        }
        public abstract void Accept(IVisitor visitor);
        public abstract bool CanPutItem(Item item);
        public abstract void PutItem(Item item);
    }
}