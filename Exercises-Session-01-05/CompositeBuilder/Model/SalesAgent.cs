using System;

namespace CompositeBuilder
{
    public abstract class SalesUnit
    {
        public string Name { get; private set; }
        protected SalesUnit(string name)
        {
            Name = name;
        }


    }
    public class SalesAgent : SalesUnit
    {
        public SalesAgent(string name) : base(name)
        {
        }
    }
}
