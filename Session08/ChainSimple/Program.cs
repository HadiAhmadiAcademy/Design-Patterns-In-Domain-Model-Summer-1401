using System;

namespace ChainSimple
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var request = " test ";

            var handler = GetHandler();
            handler.Handle(request);

            Console.WriteLine(request);
            Console.ReadLine();
        }

        private static IHandler<string> GetHandler()
        {
            var builder = new ChainBuilder<string>();
            return builder.With<TrimHandler>()
                          .With<UppercaseHandler>()
                          .Build();

            //return builder.With(new TrimHandler())
            //              .With(new UppercaseHandler())
            //              .Build();

            //var trimHandler = new TrimHandler();
            //var uppercaseHandler = new TrimHandler();
            //trimHandler.SetSuccessor(uppercaseHandler);
            //return trimHandler;
        }
    }
}