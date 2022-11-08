using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualitySample
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var list1 = new List<string>();
            var list2 = new List<string>();

            var result = list1.Except(list2);
        }

    }

    public class MyCustomComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode(string obj)
        {
            throw new NotImplementedException();
        }
    }
}
