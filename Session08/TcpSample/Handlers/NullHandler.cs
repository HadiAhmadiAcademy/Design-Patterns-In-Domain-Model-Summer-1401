namespace TcpSample.Handlers
{
    public class NullHandler : IHandler<TcpPacket>
    {
        public static IHandler<TcpPacket> Instance = new NullHandler();
        private NullHandler() { }
        public void Handle(TcpPacket request)
        {
            request.Response = "UNKNOWN_MESSAGE";
        }

        public void SetSuccessor(IHandler<TcpPacket> nextHandler)
        {
        }
    }
}