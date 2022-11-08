namespace UnsubscribeSample.Framework
{
    //for education purposes, we write this class and don't use .NET Core IObservable<T> class
    public interface IObservable<T>     
    {
        ISubscription Subscribe(IObserver<T> observer);
    }

}