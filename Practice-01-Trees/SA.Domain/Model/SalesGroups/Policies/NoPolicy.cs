namespace SA.Domain.Model.SalesGroups.Policies;

public class NoPolicy : SalesGroupStructurePolicy
{
    public static SalesGroupStructurePolicy Instance => new NoPolicy();
    private NoPolicy() { }

    public override bool IsSatisfiedBy(Placement entity)
    {
        return true;
    }
}