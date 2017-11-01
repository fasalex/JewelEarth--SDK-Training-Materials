
using JewelAddinTraining.Application.Api.Models;
using JewelAddinTraining.Application.Api.Services;
using JewelAddinTraining.Application.Core.Services;
using Joa.JewelEarth.Basics;
using Joa.JewelEarth.Infrastructure.Startup.Abstractions;

namespace JewelAddinTraining.Application.Core
{
    public sealed class Module : IAppModule
    {
        public void Configuration(IAppBuilder builder)
        {

            builder.UseServiceRegistration(x =>
                                           {
                                               x.Register<IModelQueryService<CustomDomainObjectModel>, CustomDomainObjectService>();
                                               x.Register<ICustomDomainObjectService, CustomDomainObjectService>();
                                           });
        }
    }
}