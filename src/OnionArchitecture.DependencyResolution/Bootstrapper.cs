using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Core.ApplicationService;
using OnionArchitecture.Core.DomainService;
using OnionArchitecture.Infrastructure.Data.EntityFramework;
using OnionArchitecture.Infrastructure.Data.Repositories;
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

            container.Register<ILoggingService, LoggingService>();
            container.Register<DbContext, StoreContext>(); 
            container.Register<ICategoryRepository, CategoryRepository>();
            container.Register<IProductRepository, ProductRepository>();
            container.Register<IProductService, ProductService>();

            return container;
        }
    }
}
