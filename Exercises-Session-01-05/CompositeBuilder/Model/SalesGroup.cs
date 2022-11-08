using System.Collections.Generic;

namespace CompositeBuilder
{
    public class SalesGroup : SalesUnit
    {
        private List<SalesUnit> _units;
        public SalesGroup(string name) : base(name)
        {
            _units = new List<SalesUnit>();
        }

        public void AddChild(SalesUnit unit)
        {
            _units.Add(unit);
        }
    }
}