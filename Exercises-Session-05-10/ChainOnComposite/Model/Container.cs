using System.Collections.Generic;
using System.Linq;
using ChainOnComposite.Visitors;

namespace ChainOnComposite.Model
{
    public abstract class Container
    {
        public abstract long TotalCapacity();
        public abstract long UsedCapacity();
        public long RemainingCapacity()
        {
            return TotalCapacity() - UsedCapacity();
        }
        public abstract void Accept(IVisitor visitor);
        public abstract Liquid Fill(Liquid liquid);
    }
}