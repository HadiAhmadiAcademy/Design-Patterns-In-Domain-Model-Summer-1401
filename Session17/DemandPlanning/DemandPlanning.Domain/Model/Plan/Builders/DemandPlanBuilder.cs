namespace DemandPlanning.Domain.Model.Plan.Builders;

internal class DemandPlanBuilder : IDemandPlanBuilder, IDemandPlanPeriodBuilder
{
    public IDemandPlanPeriodBuilder From(DateTime start)
    {
        return this;
    }
    public IDemandPlanBuilder Until(DateTime start)
    {
        return this;
    }
    public IDemandPlanBuilder AddWeek()
    {
        return this;
    }
    public IDemandPlanBuilder AddToDay(DayOfWeek dayOfWeek, Demand demand)
    {
        return this;
    }
    public DemandPlan Build()
    {
        return null;
    }
}

public interface IDemandPlanBuilder
{
    IDemandPlanBuilder AddWeek();
    IDemandPlanBuilder AddToDay(DayOfWeek dayOfWeek, Demand demand);
    DemandPlan Build();
}

public interface IDemandPlanPeriodBuilder
{
    IDemandPlanPeriodBuilder From(DateTime start);
    IDemandPlanBuilder Until(DateTime start);
}