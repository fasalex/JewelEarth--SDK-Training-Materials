
using Joa.JewelEarth.Infrastructure.Startup.Abstractions;
using Joa.JewelEarth.UI.Framework.Infrastructure;
using JewelAddinTraining.UI.Windows.Logic.Properties;
using JewelAddinTraining.UI.Windows.Logic.Actions;
using JewelAddinTraining.UI.Windows.Logic.ContextMenus;
using JewelAddinTraining.UI.Windows.Logic.ViewModels;
using JewelAddinTraining.UI.Windows.Logic.Views;
using Joa.JewelEarth.UI.Forms.Routing;
using Joa.JewelEarth.UI.Forms.Startup;

namespace JewelAddinTraining.UI.Windows.Logic
{
    public sealed class Module : IAppModule
    {
        public void Configuration(IAppBuilder builder)
        {
            builder.UseFormsRegistration(x =>
                                         {
                                             x.Map("Default-Route-Prefix", m =>
                                                                           {
                                                                               m.Route("CreateCustomObject-Default-Route-Prefix")
                                                                                .ViewModel<CreateCustomObjectViewModel>()
                                                                                .View<CreateCustomObjectView>();
                                                                           });
                                         });
            builder.UseFormsRegistration(x =>
            {
                {
                    x.Map("Default-Route-Prefix", m =>
                                                  {
                                                      m.Route("CreateNewView-Default-Route-Prefix")
                                                       .ViewModel<CreateNewViewViewModel>()
                                                       .View<CreateNewViewView>()
                                                       .Controller<IDocumentViewRoutingController>();
                                                  });
                }
            });
            builder.UseFormsRegistration(x =>
                                         {
                                             x.Map("Default-Route-Prefix", m =>
                                                                           {
                                                                               m.Route("CreatePolylineSetAction-Default-Route-Prefix")
                                                                                .ViewModel<CreatePolylineSetViewModel>()
                                                                                .View<CreatePolylineSetView>();
                                                                           });
                                         });
            builder.UseActionRegistration(x =>
                                          {
                                              x.Register<CreatePolylineSetAction>();
                                              x.Register<CreateCustomObjectAction>();
                                              x.Register<CreateNewViewAction>();
                                              x.Register<CustomDomainObjectContextMenuAction>();
                                          });
            builder.UsePluginLayoutDefinitionRegistration(x => { x.Register(@"JewelAddinTraining.UI.Windows.Logic.Plugin.pldf", typeof(Resources)); });
        }
    }
}