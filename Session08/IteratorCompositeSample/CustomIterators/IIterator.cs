namespace IteratorCompositeSample.CustomIterators
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}