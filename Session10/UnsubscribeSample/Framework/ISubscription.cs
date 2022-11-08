using System;

namespace UnsubscribeSample.Framework
{
    public interface ISubscription : IDisposable
    {
        void Unsubscribe();
    }

    public abstract class Subscription : ISubscription
    {
        public void Dispose()
        {
            Unsubscribe();
        }
        public abstract void Unsubscribe();
    }

    public class ActionBasedSubscription : Subscription
    {
        private readonly Action _unsubscribe;
        public ActionBasedSubscription(Action unsubscribe)       //Function-pointer
        {
            _unsubscribe = unsubscribe;
        }
        public override void Unsubscribe()
        {
            _unsubscribe();
        }
    }
}