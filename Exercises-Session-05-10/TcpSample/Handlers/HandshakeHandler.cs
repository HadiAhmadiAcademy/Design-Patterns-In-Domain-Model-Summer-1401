namespace TcpSample.Handlers
{
    public class HandshakeHandler : Handler<TcpRequestPacket, TcpResponsePacket>
    {
        private bool _isAuthenticated;
        public override TcpResponsePacket Handle(TcpRequestPacket request)
        {
            if (request.Message == "HAND_SHAKE")
            {
                _isAuthenticated = true;
                return new TcpResponsePacket("Success");
            }

            if (_isAuthenticated)
                return CallNext(request);

            return new TcpResponsePacket("Unauthorized_Access");
        }
    }
}