using SA.Domain.Framework;
using SA.Domain.Model.SalesGroups.Policies;

namespace SA.Domain.Model.SalesGroups
{
    public class SalesGroup : AggregateRoot<long>
    {
        public SalesUnit Members { get; private set; }
        public SalesGroupStructurePolicy Policies { get; private set; }
        public SalesGroup(SalesUnit root)
        {
            this.Members = root;
            this.Policies = NoPolicy.Instance;
        }
        public void SetPolicy(SalesGroupStructurePolicy policy)
        {
            this.Policies = policy;
        }
        public void PlaceMember(SalesUnit unit, int parentId)
        {
            if (unit.Members.Any()) throw new NotSupportedException("appending tree to a tree is not supported");

            var parent = Members.FirstOrDefault(a => a.Id == parentId);
            //TODO: check for non-existing parent
         
            var placementOperation = new Placement(unit, parent, this);
            if (Policies.IsSatisfiedBy(placementOperation))
            {
                parent.AddMember(unit);
                //parent.AddMember(unit, policies, placementOperation); //to check the validation in entity itself
            }
            else
            {
                // returning an error 
            }
        }
    }
}