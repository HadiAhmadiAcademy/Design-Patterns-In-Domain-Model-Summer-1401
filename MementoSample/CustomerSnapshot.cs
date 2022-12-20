namespace MementoSample
{
    //Memento
    public class CustomerSnapshot
    {
        public long Value { get;  }
        public CustomerSnapshot(long value)
        {
            Value = value;
        }
    }
}