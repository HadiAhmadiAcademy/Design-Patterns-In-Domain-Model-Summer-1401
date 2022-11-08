using System;

namespace CompositeBuilder
{
    public interface ISalesUnitNameBuilder
    {
        ISalesUnitBuilder Named(string name);
    }

    public interface ISalesUnitBuilder
    {
        ISalesUnitBuilder WithAgent(string agentName);
        ISalesUnitBuilder WithGroup(Action<ISalesUnitNameBuilder> builderConfig);
        SalesUnit Build();
    }
}