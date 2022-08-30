using System;
using System.Collections.Generic;
using System.Text;
using DoubleDispatch.Boards;
using DoubleDispatch.Shapes;

namespace DoubleDispatch
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var board = new WhiteBoard();
            Shape shape = CreateShape();

            ////board.Draw(shape);
            //board.Draw(shape as dynamic);   //Multiple Dispatch

            shape.DrawOn(board);            //Double Dispatch
        }

        private static Shape CreateShape()
        {
            return new Circle();
        }
    }
}
