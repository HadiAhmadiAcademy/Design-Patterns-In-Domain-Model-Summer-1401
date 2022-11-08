using System.Collections.Generic;
using System.Linq;

namespace IteratorCompositeSample.CustomIterators
{
    public class FirstBreadthIterator : IIterator<Node>
    {
        private Queue<Node> _items = new Queue<Node>();
        public FirstBreadthIterator(Node node)
        {
            _items.Enqueue(node);
        }
        public bool HasNext()
        {
            return _items.Any();
        }
        public Node Next()
        {
            //TODO: consider getting iterator from child instead of getting the children
            var currentItem = _items.Dequeue();
            foreach (var child in currentItem.GetChildren())
                _items.Enqueue(child);
            return currentItem;
        }
    }
}