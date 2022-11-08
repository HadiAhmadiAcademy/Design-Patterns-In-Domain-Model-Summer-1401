using System;
using System.Collections.Generic;
using System.Linq;

namespace ChainSimple
{
    public class ChainBuilder<T>
    {
        private readonly List<IHandler<T>> _handlers = new List<IHandler<T>>();
        public ChainBuilder<T> With(IHandler<T> handler)
        {
            _handlers.Add(handler);
            return this;
        }

        public ChainBuilder<T> With<THandler>() where THandler : IHandler<T>, new()
        {
            var handler = new THandler();
            return With(handler);
        }

        public IHandler<T> Build()
        {
            _handlers.Aggregate((a, b) =>
            {
                a.SetSuccessor(b);
                return b;
            });
            return _handlers.First();
        }
    }
}