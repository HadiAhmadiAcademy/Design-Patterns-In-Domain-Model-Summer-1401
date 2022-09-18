using System;

namespace LoggingSample
{
    public interface ILogger
    {
        void WriteDebug(string message);
        void WriteInfo(string message);
        void WriteWarning(string message);
    }

    public class Log4NetAdapter : ILogger //, Log4NetLogger
    {
        //... 
        public void WriteDebug(string message)
        {
            //base.Debug(...)
        }

        public void WriteInfo(string message)
        {
            throw new NotImplementedException();
        }

        public void WriteWarning(string message)
        {
            throw new NotImplementedException();
        }
    }

    public class SeriLogAdapter : ILogger
    {
        // Serilog.ILogger _logger;
        public void WriteDebug(string message)
        {
            throw new NotImplementedException();
        }

        public void WriteInfo(string message)
        {
            throw new NotImplementedException();
        }

        public void WriteWarning(string message)
        {
            throw new NotImplementedException();
        }
    }
}
