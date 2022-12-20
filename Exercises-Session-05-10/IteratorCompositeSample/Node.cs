using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using IteratorCompositeSample.CustomEnumerators;

namespace IteratorCompositeSample
{
    public class Node : IEnumerable<Node>
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
        public IReadOnlyList<Node> GetChildren() => _subNodes;
        public bool HasChildren() => _subNodes.Any();
        public IEnumerator<Node> GetEnumerator()
        {
            return new FirstBreadthEnumerator(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
