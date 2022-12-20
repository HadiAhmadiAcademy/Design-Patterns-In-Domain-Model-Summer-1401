namespace TcpSample
{
    public class TcpRequestPacket
    {
        public string Message { get; set; }
    }

    public class TcpResponsePacket
    {
        public string Message { get; set; }
        public TcpResponsePacket(string message)
        {
            Message = message;
        }
    }
}