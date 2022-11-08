using System;
using PrototypeSample.WorkflowDesigner;

namespace PrototypeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var element = GetElement();

            var copy = element.Clone();

        }

        private static IEditorElement GetElement()
        {
            return new Rectangle(10,20);
        }
    }
}
