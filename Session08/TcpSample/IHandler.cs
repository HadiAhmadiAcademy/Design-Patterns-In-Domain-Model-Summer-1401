namespace TcpSample
{
    public interface IHandler<T>
    {
        public void SetSuccessor(IHandler<T> successor);
        void Handle(T request);
    }
}