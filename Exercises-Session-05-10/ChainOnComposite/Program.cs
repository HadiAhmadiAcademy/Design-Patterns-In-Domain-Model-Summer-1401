using System;
using System.Collections.Generic;
using System.Linq;
using ChainOnComposite.Model;
using ChainOnComposite.Visitors;

namespace ChainOnComposite
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var shelf1 = new Shelf();

            var shelf2 = new Shelf();
            var shelf3 = new Shelf();

            shelf1.AddContainer(shelf2, shelf3);

            var box1 = new Gallon(10);
            var box2 = new Gallon(20);
            var box3 = new Gallon(15);
            var box4 = new Gallon(30);

            shelf2.AddContainer(box1, box2);
            shelf3.AddContainer(box3, box4);

            //---------------------
            var hundredLitersOfWater = new Liquid(100);
            hundredLitersOfWater = shelf1.Fill(hundredLitersOfWater);
            //---------------------

            Console.WriteLine("------------");
            Console.WriteLine($"Remaining Water : {hundredLitersOfWater.Amount}");
            Console.WriteLine("------------");

            var graph = DrawGraph(shelf1);
            Console.WriteLine(graph);
            Console.ReadLine();
        }

        private static string DrawGraph(Container container)
        {
            var graphMaker = new GraphDrawer();
            container.Accept(graphMaker);
            var graph = graphMaker.GetGraph();
            return graph;
        }
    }
}