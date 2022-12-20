namespace TcpSample
{
    public interface IHandler<TRequest, TResponse>
    {
        public void SetSuccessor(IHandler<TRequest, TResponse> successor);
        TResponse Handle(TRequest request);
    }

    public abstract class Handler<TRequest, TResponse> : IHandler<TRequest, TResponse>
    {
        private IHandler<TRequest, TResponse> _next;
        public void SetSuccessor(IHandler<TRequest, TResponse> successor)
        {
            _next = successor;
        }

        public TResponse CallNext(TRequest request)
        {
            return _next.Handle(request);
        }

        public abstract TResponse Handle(TRequest request);
    }
}