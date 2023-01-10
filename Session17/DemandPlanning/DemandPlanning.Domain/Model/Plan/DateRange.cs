using DemandPlanning.Domain.Framework;

namespace DemandPlanning.Domain.Model.Plan;

public class DateRange : ValueObject<DateRange>
{
    public DateRange(DateTime startDate, DateTime endDate)
    {
        Start = startDate;
        End = endDate;

        if (End < Start)
        {
            throw new ArgumentException("endDate must be greater than or equal to startDate");
        }
    }
    public DateTime Start { get; private set; }
    public DateTime End { get; private set; }
    public IList<DateTime> Dates
    {
        get
        {
            var startDate = Start;

            return Enumerable.Range(0, Days)
                .Select(offset => startDate.AddDays(offset))
                .ToList();
        }
    }
    public int Days
    {
        get { return (End - Start).Days + 1; }
    }

    protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
    {
        yield return this.Start;
        yield return this.End;
    }

    public DateRange ShiftToNextPeriod()
    {
        return new DateRange(this.End.AddDays(1), this.End.AddDays(this.Days));
    }
}