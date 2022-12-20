namespace TcpSample.Handlers
{
    public class NullHandler : IHandler<TcpRequestPacket, TcpResponsePacket>
    {
        public static IHandler<TcpRequestPacket, TcpResponsePacket> Instance = new NullHandler();
        private NullHandler() { }
        public TcpResponsePacket Handle(TcpRequestPacket request)
        {
            return new TcpResponsePacket("UNKNOWN_MESSAGE");
        }

        public void SetSuccessor(IHandler<TcpRequestPacket, TcpResponsePacket> nextHandler)
        {
        }
    }
}