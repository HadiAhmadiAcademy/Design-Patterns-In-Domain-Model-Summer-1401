using System;

namespace MementoSample
{
    public class Customer
    {
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string Address { get; private set; }
        public Point Points { get; private set; }

        public Customer(string firstname, string lastname, string address)
        {
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            this.Points = Point.Zero();
        }

        public void AddPoints(Point point)
        {
            this.Points += point;
        }
        public CustomerSnapshot SaveSnapshot()
        {
            return new CustomerSnapshot(this.Points.Value);
        }
        public void Restore(CustomerSnapshot snapshot)
        {
            this.Points = new Point(snapshot.Value);
        }

    }
}
