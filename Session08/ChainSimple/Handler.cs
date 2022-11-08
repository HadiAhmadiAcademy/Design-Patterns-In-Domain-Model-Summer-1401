namespace ChainSimple
{
    public abstract class Handler<TRequest> : IHandler<TRequest>
    {
        private IHandler<TRequest> _successor;
        protected Handler()
        {
            this._successor = NullHandler<TRequest>.Instance;
        }
        public abstract TRequest Handle(TRequest request);
        public void SetSuccessor(IHandler<TRequest> nextHandler)
        {
            _successor = nextHandler;
        }

        public TRequest CallNext(TRequest request)
        {
            return _successor.Handle(request);
        }
    }
}