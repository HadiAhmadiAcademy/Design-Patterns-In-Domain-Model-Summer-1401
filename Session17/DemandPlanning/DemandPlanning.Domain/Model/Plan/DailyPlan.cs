using DemandPlanning.Domain.Framework;

namespace DemandPlanning.Domain.Model.Plan;

public class DailyPlan : Entity<DayOfWeek>
{
    private List<Demand> _demandsOfDay;
    public IReadOnlyList<Demand> DemandsOfDay => _demandsOfDay;

    public DailyPlan Clone()
    {
        return new DailyPlan()
        {
            Id = this.Id,
            _demandsOfDay = _demandsOfDay.Select(a => a.Clone()).ToList(),
        };
    }
}