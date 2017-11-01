
using Joa.JewelEarth.Infrastructure.Startup.Abstractions;
using Joa.JewelEarth.UI.Framework.Infrastructure;
using JewelAddinTraining.UI.Windows.Logic.Properties;

namespace JewelAddinTraining.UI.Windows.Logic
{
    public sealed class Module : IAppModule
    {
        public void Configuration(IAppBuilder builder)
        {
            builder.UsePluginLayoutDefinitionRegistration(x => { x.Register(@"JewelAddinTraining.UI.Windows.Logic.Plugin.pldf", typeof(Resources)); });
        }
    }
}