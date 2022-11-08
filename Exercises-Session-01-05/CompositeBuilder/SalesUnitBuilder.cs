using System;

namespace CompositeBuilder
{
    public class SalesUnitBuilder : ISalesUnitBuilder, ISalesUnitNameBuilder
    {
        private SalesGroup _root;
        private SalesUnitBuilder() { }

        public static ISalesUnitBuilder Create(string rootGroupName)
        {
            var builder = new SalesUnitBuilder();
            return builder.Named(rootGroupName);
        }

        public ISalesUnitBuilder Named(string name)
        {
            _root = new SalesGroup(name);
            return this;
        }
        public ISalesUnitBuilder WithAgent(string agentName)
        {
            var salesAgent = new SalesAgent(agentName);
            _root.AddChild(salesAgent);
            return this;
        }
        public ISalesUnitBuilder WithGroup(Action<ISalesUnitNameBuilder> builderConfig)
        {
            var builder = new SalesUnitBuilder();
            builderConfig.Invoke(builder);
            _root.AddChild(builder.Build());
            return this;
        }
        public SalesUnit Build()
        {
            return _root;
        }

    }
}