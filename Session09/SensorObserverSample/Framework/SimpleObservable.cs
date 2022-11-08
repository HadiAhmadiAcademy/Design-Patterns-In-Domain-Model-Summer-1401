using System.Collections.Generic;

namespace SensorObserverSample.Framework
{
    public class SimpleObservable<T> : Framework.IObservable<T>
    {
        private readonly List<IObserver<T>> _observers = new List<IObserver<T>>();
        public void Subscribe(IObserver<T> observer)
        {
            _observers.Add(observer);
        }

        protected void NotifyAllObservers(T value)
        {
            foreach (var observer in _observers)
                observer.Notify(value);
        }
    }
}