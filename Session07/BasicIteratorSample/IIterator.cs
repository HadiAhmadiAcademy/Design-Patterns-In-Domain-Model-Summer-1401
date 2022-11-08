namespace BasicIteratorSample
{
    public interface IIterator<T>
    {
        bool IsDone();
        void Next();
        T CurrentItem();
    }
}