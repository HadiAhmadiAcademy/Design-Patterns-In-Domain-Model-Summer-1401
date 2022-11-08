using System;
using System.Text;
using ChainOnComposite.Model;

namespace ChainOnComposite.Visitors
{
    public class GraphDrawer : IVisitor
    {
        private StringBuilder _graph = new StringBuilder();
        private int indent = 0;

        public void Visit(Shelf shelf)
        {
            _graph.AppendLine($"{GetIndent(indent)} Shelf (Cap: {shelf.TotalCapacity()} | Remaining: {shelf.RemainingCapacity()})");
            indent++;
            foreach (var container in shelf.InnerContainers)
            {
                container.Accept(this);
            }
            indent--;
        }

        private string GetIndent(int i)
        {
            return new string('\t', i);
        }


        public void Visit(Box box)
        {
            _graph.AppendLine($"{GetIndent(indent)} Box (Cap: {box.TotalCapacity()} | Remaining: {box.RemainingCapacity()})");
        }

        public string GetGraph() => _graph.ToString();
    }
}