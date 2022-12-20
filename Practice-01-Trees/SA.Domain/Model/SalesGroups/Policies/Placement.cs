namespace SA.Domain.Model.SalesGroups.Policies;

public class Placement
{
    public SalesUnit Unit { get; set; }
    public SalesUnit TargetedParent { get; set; }           //you can use ID instead of real object
    public SalesGroup Group { get; set; }
    public Placement(SalesUnit unit, SalesUnit targetedParent, SalesGroup group)
    {
        Unit = unit;
        TargetedParent = targetedParent;
        Group = group;
    }
}