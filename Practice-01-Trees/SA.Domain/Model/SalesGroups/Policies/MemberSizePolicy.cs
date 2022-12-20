namespace SA.Domain.Model.SalesGroups.Policies;

public class MemberCapacityPolicy : SalesGroupStructurePolicy
{
    private readonly int _maxMembers;
    public MemberCapacityPolicy(int maxMembers)
    {
        _maxMembers = maxMembers;
    }
    public override bool IsSatisfiedBy(Placement entity)
    {
        return entity.TargetedParent.Members.Count + 1 <= _maxMembers;
    }
}