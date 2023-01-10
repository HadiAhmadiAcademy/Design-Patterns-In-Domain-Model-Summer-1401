using DemandPlanning.Domain.Framework;

namespace DemandPlanning.Domain.Model.Plan;

public class ProductId : Id<int>
{
    public ProductId(int value) : base(value)
    {
    }
}