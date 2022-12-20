using System.Collections.Generic;
using ChainOnComposite.Visitors;

namespace ChainOnComposite.Model
{
    public class Gallon : Container
    {
        private long _totalCapacity;
        private long _usedCapacity;
        public Gallon(long totalCapacity)
        {
            _totalCapacity = totalCapacity;
        }
        public override long TotalCapacity() => _totalCapacity;
        public override long UsedCapacity() => _usedCapacity;
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override Liquid Fill(Liquid liquid)
        {
            if (RemainingCapacity() >= liquid.Amount)
            {
                _usedCapacity += liquid.Amount;
                liquid.Amount = 0;
            }
            else
            {
                liquid.Amount = liquid.Amount - RemainingCapacity();
                _usedCapacity = _totalCapacity;
            }

            return liquid;
        }
    }
}