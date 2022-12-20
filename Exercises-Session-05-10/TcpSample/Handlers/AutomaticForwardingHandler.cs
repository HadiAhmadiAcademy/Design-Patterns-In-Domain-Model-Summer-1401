namespace TcpSample.Handlers
{
    public abstract class AutomaticForwardingHandler<TRequest, TResponse> : Handler<TRequest, TResponse>
    {
        private IHandler<TRequest, TResponse> _successor;
        public override TResponse Handle(TRequest request)
        {
            if (CanHandle(request))
            {
                return HandleRequest(request);
            }
            return CallNext(request);
        }
        protected abstract bool CanHandle(TRequest request);
        protected abstract TResponse HandleRequest(TRequest request);
    }
}