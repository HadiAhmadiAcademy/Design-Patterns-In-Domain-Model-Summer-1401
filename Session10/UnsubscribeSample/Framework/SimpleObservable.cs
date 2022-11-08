using System.Collections.Generic;

namespace UnsubscribeSample.Framework
{
    public class SimpleObservable<T> : Framework.IObservable<T>
    {
        private readonly List<IObserver<T>> _observers = new List<IObserver<T>>();
        public ISubscription Subscribe(IObserver<T> observer)
        {
            _observers.Add(observer);
            return new ActionBasedSubscription(()=> this._observers.Remove(observer));
        }
        protected void NotifyAllObservers(T value)
        {
            foreach (var observer in _observers)
                observer.Notify(value);
        }
    }
}