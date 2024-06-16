using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace ConsoleAppWithUnityBlocks
{
    internal static class Bootstraper
    {
        public static IUnityContainer Initialize()
            
        {
            var container = BuildUnityContainer();
            
            return container;
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.EnableDiagnostic();
            RegisterTypes(container);
            return container;
        }
        private static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IBasicService, BasicService>();

            //with lifetime
            //container.RegisterType<IBasicService, BasicService>(TypeLifetime.Scoped);

            //registering using the factory and factory lifetime.singleton
            //container.RegisterFactory<IBasicService>((c, t, n) => new BasicService(), FactoryLifetime.Singleton);

            //registering using the instance and instancelifetime.singleton - default is per container
            //var service = new BasicService();
            //container.RegisterInstance<IBasicService>(service, InstanceLifetime.Singleton);
            container.RegisterType<ServiceDependentClass>(TypeLifetime.Singleton);
            container.RegisterType<AddOnClassForCircularDependancy>();
        }
    }

}
