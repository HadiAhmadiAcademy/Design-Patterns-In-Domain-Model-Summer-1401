namespace UnsubscribeSample.Framework
{
    public interface IObserver<T>
    {
        void Notify(T value);
    }
}