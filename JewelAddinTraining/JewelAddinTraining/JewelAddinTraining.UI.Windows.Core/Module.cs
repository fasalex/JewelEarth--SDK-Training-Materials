
using System.Reflection;
using JewelAddinTraining.Domain.Api.Items;
using JewelAddinTraining.UI.Windows.Core.Controllers;
using Joa.JewelEarth.Basics;
using Joa.JewelEarth.Infrastructure.Startup.Abstractions;
using Joa.JewelEarth.Services;
using Joa.JewelEarth.UI.JewelExplorer;
using Joa.JewelEarth.UI.JewelExplorer.Services;

namespace JewelAddinTraining.UI.Windows.Core
{
    public sealed class Module : IAppModule
    {
        public void Configuration(IAppBuilder builder)
        {
            builder.WhenServiceResolverReady(x =>
                                             {
                                                 var controllerService = x.Resolve<IJewelExplorerControllerService>();
                                                 IControllerConfiguration standardConfiguration = controllerService.StandardConfiguration;
                                                 standardConfiguration.RegisterController<ICustomDomainObjectContainer, CustomDomainObjectController>();

                                                Assembly assembly = GetType().Assembly;
                                                var imageService = x.Resolve<IImageService>();
                                                imageService.Register(new CustomObjectIcons());
                                                imageService.Add(@"CustomObjectContainer", ResourceManager.GetImage(assembly, @"CustomDomainObjectContainer.png"));
                                                imageService.Add(@"CustomObject", ResourceManager.GetImage(assembly, @"CustomDomainObject.png"));
                                             });
        }


       
    }
}