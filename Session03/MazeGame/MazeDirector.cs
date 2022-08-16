using MazeGame.Builders;

namespace MazeGame
{
    public class MazeDirector
    {
        private readonly IMazeBuilder _builder;
        public MazeDirector(IMazeBuilder builder)
        {
            _builder = builder;
        }
        public void EasyMaze()
        {
            _builder.AddRoom(1);
            _builder.AddRoom(2);
            _builder.AddDoor(1,2);
        }
        public void DifficultMaze()
        {
            _builder.AddRoom(1);
            _builder.AddRoom(2);
            _builder.AddDoor(1, 2);
            //..
            _builder.AddRoom(1000);
            //..
        }
    }
}