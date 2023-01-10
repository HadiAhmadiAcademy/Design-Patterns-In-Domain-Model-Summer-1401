using DemandPlanning.Domain.Framework;

namespace DemandPlanning.Domain.Model.Plan;

public class WeeklyPlan : Entity<int>
{
    private List<DailyPlan> _planOfDays;
    public IReadOnlyList<DailyPlan> PlanOfDays => _planOfDays;
    internal WeeklyPlan(int id, List<DailyPlan> planOfDays)
    {
        this.Id = id;
        this._planOfDays = planOfDays;
    }
    internal WeeklyPlan Clone()
    {
        return new WeeklyPlan(this.Id, _planOfDays = _planOfDays.Select(a => a.Clone()).ToList());
    }
}