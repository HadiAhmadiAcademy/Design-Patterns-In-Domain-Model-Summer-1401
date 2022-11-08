namespace TcpSample.Handlers
{
    public class HeartbeatHandler : Handler<TcpPacket>
    {
        public override void Handle(TcpPacket request)
        {
            if (request.Message == "HEART_BEAT")
                request.Response = "ACK";
            else
                CallNext(request);
        }
    }
}