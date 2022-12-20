namespace MementoSample
{
    public class Point
    {
        public static Point Zero()=> new Point(0);
        public long Value { get; }
        public Point(long value)
        {
            Value = value;
        }
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.Value + p2.Value);
        }
    }
}