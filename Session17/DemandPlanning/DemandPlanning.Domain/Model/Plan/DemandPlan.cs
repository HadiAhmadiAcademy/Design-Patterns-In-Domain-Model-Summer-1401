using DemandPlanning.Domain.Framework;

namespace DemandPlanning.Domain.Model.Plan;

public class DemandPlan : AggregateRoot<DemandPlanId>
{
    private List<WeeklyPlan> _weeks;
    public DateRange Period { get; private set; }
    public IReadOnlyList<WeeklyPlan> Weeks => _weeks;
    internal DemandPlan(List<WeeklyPlan> weeks, DateRange period)
    {
        this.Id = DemandPlanId.New();
        _weeks = weeks;
        Period = period;
    }
    private DemandPlan() { }
    public DemandPlan MakeACopyForNewPeriod(DateRange period)
    {
        return new DemandPlan()
        {
            Period = period,
            Id = DemandPlanId.New(),
            _weeks = this._weeks.Select(a=> a.Clone()).ToList()
        };
    }
    public DemandPlan MakeACopyAppendingThisPlan()
    {
        var period = this.Period.ShiftToNextPeriod();
        return MakeACopyForNewPeriod(period);
    }
    public List<Demand> GetDemandsForDate(DateTime time)
    {
        return null;
    }
}