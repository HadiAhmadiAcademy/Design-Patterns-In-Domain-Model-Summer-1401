namespace TcpSample.Handlers
{
    public class PrintHandler : AutomaticForwardingHandler<TcpRequestPacket, TcpResponsePacket>
    {
        protected override bool CanHandle(TcpRequestPacket request)
        {
            return request.Message == "PRINT";
        }

        protected override TcpResponsePacket HandleRequest(TcpRequestPacket request)
        {
            return new TcpResponsePacket("Printed !");
        }
    }
}