using System;
using Xunit;

namespace CompositeBuilder.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Root
            //      | - Group 1
                //      | - Agent X
                //      | - Agent Y
            //      |Agent Z


            var group = SalesUnitBuilder.Create("Root")
                        .WithGroup(a=> a.Named("Group1").WithAgent("Agent X").WithAgent("Agent Y"))
                        .WithAgent("AgentZ")
                    .Build();

            
        }
    }
}
