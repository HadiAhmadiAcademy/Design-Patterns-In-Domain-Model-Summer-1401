using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DotNetIterators
{
    public class FruitBasket : IEnumerable<string>
    {
        private string[] fruits = new[] { "Apple", "Orange", "Banana" };
        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
