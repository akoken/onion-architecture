using App.Infrastructure.Interfaces;
using Ninject.Modules;
using App.Infrastructure.Data.Services;

namespace App.Infrastructure.DependencyResolution
{
    public class ConfigModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IConfigService>().To<ConfigService>();
        }
    }
}
