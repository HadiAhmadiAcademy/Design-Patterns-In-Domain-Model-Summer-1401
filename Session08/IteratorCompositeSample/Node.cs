using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using IteratorCompositeSample.CustomIterators;

namespace IteratorCompositeSample
{
    public class Node
    {
        public string Name { get; private set; }
        private readonly List<Node> _subNodes = new List<Node>();
        public Node(string name)
        {
            Name = name;
        }
        public void Add(Node node)
        {
            this._subNodes.Add(node);
        }
        public void Add(params Node[] node)
        {
            this._subNodes.AddRange(node);
        }
        public void ForEach(Action<Node> action)
        {
            var iterator = this.CreateIterator();
            while (iterator.HasNext())
            {
                var node = iterator.Next();
                action(node);
            }
        }
        public IReadOnlyList<Node> GetChildren() => _subNodes;
        public bool HasChildren() => _subNodes.Any();

        public IIterator<Node> CreateIterator()
        {
            return new FirstBreadthIterator(this);
        }
    }
}
