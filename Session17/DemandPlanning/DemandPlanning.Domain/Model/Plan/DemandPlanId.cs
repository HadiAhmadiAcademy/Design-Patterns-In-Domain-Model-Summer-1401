using DemandPlanning.Domain.Framework;

namespace DemandPlanning.Domain.Model.Plan;

public class DemandPlanId : Id<Guid>
{
    public DemandPlanId(Guid value) : base(value)
    {
    }
    public static DemandPlanId New() => new(Guid.NewGuid());
}