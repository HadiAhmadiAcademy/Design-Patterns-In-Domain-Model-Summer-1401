using System;
using System.Collections.Generic;

namespace BasicIteratorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var basket = GetBasket();
            var iterator = basket.CreateIterator();

            while (!iterator.IsDone())          //
            {
                var item = iterator.CurrentItem();  //
                Console.WriteLine(item);
                iterator.Next();            //
            }

            //---------------------
            var list = new List<int>(){1,2,3,4,5};
            list.ForEach(a=> Console.WriteLine(a));
        }
        private static IBasket<string> GetBasket()
        {
            return new FruitBasket();
        }
    }
}
