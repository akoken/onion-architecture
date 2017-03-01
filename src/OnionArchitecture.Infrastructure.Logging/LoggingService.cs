using OnionArchitecture.Core.ApplicationService;
using Serilog;

namespace OnionArchitecture.Infrastructure.Logging
{
    public class LoggingService : ILoggingService
    {
        public LoggingService()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .Enrich.FromLogContext()
                .CreateLogger();
        }

        public void Error(string errorMessage)
        {
            Log.Error(errorMessage);
        }

        public void Information(string information)
        {
            Log.Information(information);
        }

        public void Warning(string warningMessage)
        {
            Log.Warning(warningMessage);
        }
    }
}
