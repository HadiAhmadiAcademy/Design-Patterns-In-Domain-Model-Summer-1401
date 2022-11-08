namespace CompositeObservable.Framework
{
    public interface IObserver<T>
    {
        void Notify(T value);
    }
}