namespace TcpSample.Handlers
{
    public class HeartbeatHandler : AutomaticForwardingHandler<TcpRequestPacket, TcpResponsePacket>
    {
        protected override bool CanHandle(TcpRequestPacket request)
        {
            return request.Message == "HEART_BEAT";
        }

        protected override TcpResponsePacket HandleRequest(TcpRequestPacket request)
        {
            return new TcpResponsePacket("ACK");
        }
    }
}