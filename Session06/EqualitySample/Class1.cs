using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualitySample
{
    public class Class1
    {
        public Class1()
        {
            var list1 = new List<string>();
            var list2 = new List<string>();

            var result = list1.Except(list2, new MyCustomComparer());
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
