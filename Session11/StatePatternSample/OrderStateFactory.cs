using System.Collections.Concurrent;
using System.Collections.Generic;

namespace StatePatternSample
{
    public class OrderStateFactory      //Flyweight-Factory-Sample
    {
        private static ConcurrentDictionary<string, OrderState> _cachedStates = new ConcurrentDictionary<string, OrderState>();
        public static OrderState Create<T>() where T : OrderState, new()
        {
            var name = typeof(T).Name.ToLower();
            if (_cachedStates.ContainsKey(name))
                return _cachedStates[name];

            var state = new T();
            _cachedStates.TryAdd(name, state);
            return state;
        }
    }
}