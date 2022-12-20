using System;
using TcpSample.Handlers;

namespace TcpSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var packet = new TcpRequestPacket()
            {
                Message = "PRINT"
            };
            var chain = CreateHandler();

            chain.Handle(packet);

            Console.WriteLine(packet.Response);
        }

        private static IHandler<TcpRequestPacket> CreateHandler()
        {
            var chain = new ChainBuilder<TcpRequestPacket>()
                .With<HeartbeatHandler>()
                .With<HandshakeHandler>()
                .With<PrintHandler>()
                .With(NullHandler.Instance) //TODO: move this from here
                .Build();
            return chain;
        }
    }
}
