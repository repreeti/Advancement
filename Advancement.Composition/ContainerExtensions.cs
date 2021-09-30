using SimpleInjector;
using System;

namespace Advancement.Composition
{
    public static  class ContainerExtensions 
    {
        public static void RegisterProviders( this Container container)
        {
            container.Register<IAdvancementConfigurationProvider, AdvancementConfigurationProvider>(Lifestyle.Scoped);
        }
    }
}
