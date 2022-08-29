using System.Collections.Generic;
using System.Linq;

namespace Sales
{
    public class SalesGroup : SalesUnit
    {
        public List<SalesUnit> Units { get; private set; }
        public SalesGroup(List<SalesUnit> units)
        {
            Units = units;
        }
        public SalesGroup(params SalesUnit[] units) : this(units?.ToList()) { }
        public override void PayCommission(int amount)
        {
            var eachShare = amount / Units.Count;
            foreach (var salesUnit in Units)
                salesUnit.PayCommission(eachShare);
        }
    }
}