using System;

namespace IteratorCompositeSample
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var root = new Node("Root");
            var node1 = new Node("Node1");
            var node2 = new Node("Node2");
            var node3 = new Node("Node3");
            var node4 = new Node("Node4");
            var node5 = new Node("Node5");
            var node6 = new Node("Node6");
            var node7 = new Node("Node7");

            root.Add(node1, node2, node3);
            node1.Add(node4, node5);
            node5.Add(node6);
            node2.Add(node7);

            foreach (var node in root)
            {
                Console.WriteLine(node.Name);
            }

            Console.ReadLine();
        }
    }
}