using App.Infrastructure.Interfaces;
using Ninject.Modules;
using NLog;
using NLog.Config;

namespace App.Infrastructure.DependencyResolution
{
    public class LoggingModule : NinjectModule
    {
        public override void Load()
        {
            ILoggingService logger = GetLoggingService();
            Bind<ILoggingService>().ToConstant(logger);
        }

        private ILoggingService GetLoggingService()
        {
            ConfigurationItemFactory.Default.LayoutRenderers.RegisterDefinition("utc_date", typeof(UtcDateRenderer));
            ConfigurationItemFactory.Default.LayoutRenderers.RegisterDefinition("web_variables", typeof(WebVariablesRenderer));
            ILoggingService logger = (ILoggingService)LogManager.GetLogger("NLogLogger", typeof(LoggingService));
            return logger;
        }
    }
}
