using System.Data.Entity;
using SimpleInjector;
using OnionArchitecture.Infrastructure.Data;
using OnionArchitecture.Core.DomainServices;
using OnionArchitecture.Infrastructure.Data.Repositories;

namespace OnionArchitecture.Infrastructure.DependencyResolution
{
    public class IoC
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
