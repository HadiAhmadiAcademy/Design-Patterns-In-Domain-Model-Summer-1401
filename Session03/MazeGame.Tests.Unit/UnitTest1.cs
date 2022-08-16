using System;
using Xunit;

namespace MazeGame.Tests.Unit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var builder = new StandardMazeBuilder();
            var game = new MazeDirector(builder);
            game.EasyMaze();

            var maze = builder.Build();
        }
    }
}
