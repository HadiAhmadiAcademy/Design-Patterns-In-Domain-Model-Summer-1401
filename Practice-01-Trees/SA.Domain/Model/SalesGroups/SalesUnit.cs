using System.Collections;
using SA.Domain.Framework;
using SA.Domain.Model.SalesGroups.Enumerators;

namespace SA.Domain.Model.SalesGroups;

public class SalesUnit : Entity<int> , IEnumerable<SalesUnit>
{
    private List<SalesUnit> _members;
    public IReadOnlyList<SalesUnit> Members => _members;
    public string Name { get; set; }
    public SalesUnitType Type { get; set; }
    public SalesUnit(int id, string name, SalesUnitType type)
    {
        this.Id = id;       //Check this out
        this.Name = name;
        this.Type = type;
        this._members = new List<SalesUnit>();
    }
    internal void AddMember(SalesUnit unit)
    {
        this._members.Add(unit);
    }

    public IEnumerator<SalesUnit> GetEnumerator()
    {
        return new FirstBreadthEnumerator(this);
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}