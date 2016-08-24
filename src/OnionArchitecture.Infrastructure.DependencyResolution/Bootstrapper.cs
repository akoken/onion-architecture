using System.Data.Entity;
using OnionArchitecture.Core.DomainService;
using SimpleInjector;
using OnionArchitecture.Infrastructure.Data;
using OnionArchitecture.Infrastructure.Data.Repositories;

namespace OnionArchitecture.Infrastructure.DependencyResolution
{
    public class Bootstrapper
    {
        public static Container Register()
        {
            var container = new Container();

            container.RegisterPerWebRequest<DbContext, EntityDatabaseContext>();
            container.Register<ICategoryRepository, CategoryRepository>();
            container.Register<IProductRepository, ProductRepository>();
                        
            return container;
        }
    }
}
