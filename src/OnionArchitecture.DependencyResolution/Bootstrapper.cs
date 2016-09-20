using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Core.ApplicationService;
using OnionArchitecture.Core.DomainService.CommandBase;
using OnionArchitecture.Core.DomainService.Services;
using OnionArchitecture.Infrastructure.Data;
using OnionArchitecture.Infrastructure.Data.EntityFramework;
using OnionArchitecture.Infrastructure.Logging;
using OnionArchitecture.Infrastructure.Service;
using SimpleInjector;

namespace OnionArchitecture.DependencyResolution
{
    public class Bootstrapper
    {
        public static Container Register()
        {
            var container = new Container();

            container.Register<DbContext, StoreContext>();             
            container.Register<ICommandDispatcher, CommandDispatcher>();
            container.Register<ICommandExecutor, CommandExecutor>();
            container.Register<ILoggingService, LoggingService>();
            container.Register<IProductService, ProductService>();

            return container;
        }
    }
}
