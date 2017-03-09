using SimpleInjector;
using SimpleInjector.Integration.Web;
using System;

namespace OnionArchitecture.DependencyResolution
{
    public class CompositionRoot
    {
        public static Container Bootstrap()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            container.RegisterPackages(assemblies);
            return container;
        }
    }
}
