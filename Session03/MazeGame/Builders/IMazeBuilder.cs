namespace MazeGame.Builders
{
    public interface IMazeBuilder
    {
        void AddRoom(int index);
        void AddDoor(int from, int to);
        Maze Build();
    }
}