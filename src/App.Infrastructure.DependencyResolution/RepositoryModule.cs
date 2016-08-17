using App.Infrastructure.Data.Repositories;
using App.Infrastructure.Interfaces;
using Ninject;
using Ninject.Modules;
using App.Domain.Interfaces;

namespace App.Infrastructure.DependencyResolution
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            // Get config service
            var configService = Kernel.Get<IConfigService>();

            // Bind repositories
            Bind<ICategoryRepository>().To<CategoryRepository>()
                .WithConstructorArgument("connectionString", configService.Connection);
            Bind<IProductRepository>().To<ProductRepository>()
                .WithConstructorArgument("connectionString", configService.Connection);
        }
    }
}
