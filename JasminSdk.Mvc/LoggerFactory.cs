using Microsoft.Extensions.Logging;
using Serilog;

namespace ByteNuts.PrimaveraBss.JasminSdk.Mvc
{
    public static class LoggerFactory
    {
        private static readonly ILoggerFactory _loggerFactory;

        static LoggerFactory()
        {
            _loggerFactory = new Microsoft.Extensions.Logging.LoggerFactory();
            _loggerFactory.AddSerilog(dispose: true);
        }

        public static ILoggerFactory Factory() => _loggerFactory;
    }
}
