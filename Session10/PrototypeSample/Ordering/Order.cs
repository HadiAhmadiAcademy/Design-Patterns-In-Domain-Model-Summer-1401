using System.Collections.Generic;
using System.Linq;
using PrototypeSample.WorkflowDesigner;

namespace PrototypeSample.Ordering
{
    public class Order : ICloneable<Order>
    {
        private List<OrderItem> _items;
        public Order Clone()
        {
            //...
            //return new Order()
            //{
            //    _items = _items.Select(a=> a.Clone()).ToList(),

            //};
            return null;
        }
    }

    public class OrderItem : ICloneable<OrderItem>
    {
        public OrderItem Clone()
        {
            return null;
        }
    }
}