namespace DemandPlanning.Domain.Framework;

public class Id<T> : ValueObject<T>
{
    public T Value { get; private set; }
    public Id(T value)
    {
        this.Value = value;
    }
    protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
    {
        yield return this.Value;
    }
}