using System;

namespace ChainSimple
{
    public interface IHandler<TRequest>
    {
        TRequest Handle(TRequest request);
        void SetSuccessor(IHandler<TRequest> nextHandler);
    }
}
