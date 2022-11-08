using System;
using System.Collections.Generic;

namespace BasicIteratorSample
{
    public interface IBasket<T>
    {
        IIterator<T> CreateIterator();
    }

    public class FruitBasket : IBasket<string>
    {
        private string[] fruits = new[] {"Apple", "Orange", "Banana"};

        public IIterator<string> CreateIterator()
        {
            return new FruitIterator(this.fruits);
        }
    }
    public class FruitIterator : IIterator<string>
    {
        private readonly string[] _fruits;
        private int _index;
        public FruitIterator(string[] fruits)
        {
            _fruits = fruits;
        }

        public bool IsDone()
        {
            return _index == _fruits.Length;
        }
        public void Next()
        {
            _index++;
        }
        public string CurrentItem()
        {
            return _fruits[_index];
        }
    }
}