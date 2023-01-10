namespace DemandPlanning.Domain.Model.Plan.Builders;

public static class Schedule
{
    public static IDemandPlanPeriodBuilder Plan() => new DemandPlanBuilder();
}