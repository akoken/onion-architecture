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
    public class DependencyResolver 
    {       
        public static Container CreateContainer()
        {
            var container = new Container();
            var optionBuilder = new DbContextOptionsBuilder<StoreContext>();

            container.Register<IStoreContext>(() => new StoreContext(optionBuilder.Options));
            container.Register<ICommandDispatcher, CommandDispatcher>();
            container.Register<ICommandExecutor, CommandExecutor>();
            container.Register<ILoggingService, LoggingService>();
            container.Register<IProductService, ProductService>();
            container.Verify();

            return container;
        }
    }
}
