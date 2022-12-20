using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorCompositeSample.CustomEnumerators
{
    public class FirstBreadthEnumerator : IEnumerator<Node>
    {
        private Queue<Node> _items = new Queue<Node>();
        private Node _currentNode;
        private Node _rootNode;
        public FirstBreadthEnumerator(Node node)
        {
            _items.Enqueue(node);
            _rootNode = node;
        }
        public bool MoveNext()
        {
            if (!_items.Any()) return false;

            var currentItem = _items.Dequeue();
            foreach (var child in currentItem.GetChildren())
                _items.Enqueue(child);
            _currentNode =  currentItem;

            return true;
        }

        public void Reset()
        {
            _items.Clear();
            _items.Enqueue(_rootNode);
            _currentNode = null;
        }

        public Node Current => _currentNode;
        object IEnumerator.Current => Current;
        public void Dispose()
        {
        }
    }
}