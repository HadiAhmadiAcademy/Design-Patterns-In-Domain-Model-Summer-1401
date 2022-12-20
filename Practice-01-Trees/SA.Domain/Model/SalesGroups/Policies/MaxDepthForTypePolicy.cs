namespace SA.Domain.Model.SalesGroups.Policies;

public class MaxDepthForTypePolicy : SalesGroupStructurePolicy
{
    private Dictionary<SalesUnitType, int> _maxDepthForTypes;
    public MaxDepthForTypePolicy(Dictionary<SalesUnitType, int> maxDepthForTypes)
    {
        _maxDepthForTypes = maxDepthForTypes;
    }

    public override bool IsSatisfiedBy(Placement placement)
    {
        //you can put any logic for traversing the tree here, event using visitors to accumulate data from tree
        return true;
    }
}