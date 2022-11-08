using System;
using System.Collections.Generic;
using ObserverPullModelSample.Framework;

namespace ObserverPullModelSample.Model
{
    public class Box : SimpleObservable<Box>
    {
        public long Capacity { get; private set; }
        private List<Item> _items;
        public IReadOnlyList<Item> Items => _items;
        public Box()
        {
            this._items = new List<Item>();    
        }

        public void Resize(long capacity)
        {
            this.Capacity = capacity;
            NotifyAllObservers(this);
        }
        public void PutItem(Item item)
        {
            _items.Add(item);
            NotifyAllObservers(this);
        }
    }
}