namespace TcpSample.Handlers
{
    public abstract class Handler<TRequest> : IHandler<TRequest>
    {
        private IHandler<TRequest> _successor;
        public abstract void Handle(TRequest request);
        public void SetSuccessor(IHandler<TRequest> nextHandler)
        {
            _successor = nextHandler;
        }

        public void CallNext(TRequest request)
        {
            _successor.Handle(request);
        }
    }
}