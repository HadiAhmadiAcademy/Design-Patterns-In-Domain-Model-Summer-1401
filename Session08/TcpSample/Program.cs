using System;
using TcpSample.Handlers;

namespace TcpSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var packet = new TcpPacket()
            {
                Message = "PRINT"
            };
            var chain = CreateHandler();

            chain.Handle(packet);

            Console.WriteLine(packet.Response);
        }

        private static IHandler<TcpPacket> CreateHandler()
        {
            var chain = new ChainBuilder<TcpPacket>()
                .With<HeartbeatHandler>()
                .With<HandshakeHandler>()
                .With<PrintHandler>()
                .With(NullHandler.Instance) //TODO: move this from here
                .Build();
            return chain;
        }
    }
}
