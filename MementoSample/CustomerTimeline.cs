using System.Collections.Generic;

namespace MementoSample
{
    //Caretaker
    public class CustomerTimeline
    {
        private Stack<CustomerSnapshot> _history = new Stack<CustomerSnapshot>();
        public void Add(CustomerSnapshot snapshot)
        {
            _history.Push(snapshot);
        }

        public CustomerSnapshot PeekLatest()
        {
            return _history.Pop();
        }
    }
}