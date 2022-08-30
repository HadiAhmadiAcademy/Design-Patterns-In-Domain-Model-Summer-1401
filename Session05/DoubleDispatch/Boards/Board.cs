using System;
using DoubleDispatch.Shapes;

namespace DoubleDispatch.Boards
{
    public abstract class Board
    {
        public abstract void Draw(Circle circle);
        public abstract void Draw(Square square);
        public abstract void Draw(Rectangle rectangle);
    }

    public class WhiteBoard : Board
    {
        public override void Draw(Circle circle)
        {
            Console.WriteLine("Circle");
        }

        public override void Draw(Square square)
        {
            Console.WriteLine("square");
        }

        public override void Draw(Rectangle rectangle)
        {
            Console.WriteLine("Rectangle");
        }
    }
}