namespace TcpSample.Handlers
{
    public class PrintHandler : Handler<TcpPacket>
    {
        public override void Handle(TcpPacket request)
        {
            if (request.Message == "PRINT")
                request.Response = "SUCCESS";
            else
                CallNext(request);
        }
    }
}