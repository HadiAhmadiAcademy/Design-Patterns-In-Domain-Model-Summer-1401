using SA.Domain.Model.SalesGroups;
using SA.Domain.Model.SalesGroups.Policies;

namespace SA.Domain.Tests.Unit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var branch = new SalesUnit(1, "Branch", SalesUnitType.Branch);
            var group = new SalesGroup(branch);
            group.SetPolicy(new MaxDepthForTypePolicy(new Dictionary<SalesUnitType, int>()
            {
                { SalesUnitType.Broker , 2}
            }));

            var brokerA = new SalesUnit(2, "Broker A", SalesUnitType.Broker);
            var brokerB = new SalesUnit(3, "Broker B", SalesUnitType.Broker);

            var brokerC = new SalesUnit(4, "Broker C", SalesUnitType.Broker);
            var brokerD = new SalesUnit(5, "Broker D", SalesUnitType.Broker);

            var brokerZ = new SalesUnit(6, "Broker D", SalesUnitType.Broker);


            group.PlaceMember(brokerA, 1);
            group.PlaceMember(brokerB, 1);
            group.PlaceMember(brokerC, 2);
            group.PlaceMember(brokerD, 2);
            group.PlaceMember(brokerZ, 4);

        }
    }
}