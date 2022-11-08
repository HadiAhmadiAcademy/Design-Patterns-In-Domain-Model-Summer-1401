namespace ObserverPullModelSample.Framework
{
    public interface IObservable<T>     //for education purposes, we write this class and don't use .NET Core IObservable<T> class
    {
        void Subscribe(IObserver<T> observer);
    }

}