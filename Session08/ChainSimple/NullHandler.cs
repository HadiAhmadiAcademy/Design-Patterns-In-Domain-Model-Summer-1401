namespace ChainSimple
{
    public class NullHandler<T> : IHandler<T>
    {
        public static IHandler<T> Instance = new NullHandler<T>();
        private NullHandler() { }
        public T Handle(T request)
        {
            return request;
        }

        public void SetSuccessor(IHandler<T> nextHandler)
        {
        }
    }
}