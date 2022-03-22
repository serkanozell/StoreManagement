using Autofac;
using Castle.DynamicProxy;
using Core.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.DynamicProxy;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            //builder.RegisterType<EfProductRepository>().As<IProductRepository>().SingleInstance();


            //builder.RegisterType<MemoryCache>().As<IMemoryCache>();--core module e taşındı

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(new ProxyGenerationOptions()
            {
                Selector = new AspectInterceptorSelector()
            }).SingleInstance();
        }
    }
}
