using JewelAddinTraining.Domain.Api.Items;
using JewelAddinTraining.Domain.Core.Items;
using Joa.JewelEarth.Basics;
using Joa.JewelEarth.Infrastructure.Startup.Abstractions;

namespace JewelAddinTraining.Domain.Core
{
    public sealed class Module : IAppModule
    {
        public void Configuration(IAppBuilder builder)
        {
            builder.UseDomainRegistration(x =>
                                          {
                                              x.RegisterContainer<ICustomDomainObjectContainer, CustomDomainObjectContainer>();
                                          });

            builder.UseServiceRegistration(x =>
                                           {
                                               x.Register<IDomainItemQueryService<ICustomDomainObject>>(sc => sc.Resolve<CustomDomainObjectContainer>());
                                           });
        }
    }
}