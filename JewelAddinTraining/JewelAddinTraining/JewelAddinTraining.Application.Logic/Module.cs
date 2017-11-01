
using JewelAddinTraining.Application.Api.Commands;
using JewelAddinTraining.Application.Logic.Handlers;
using Joa.JewelEarth.Infrastructure.CommandProcessing;
using Joa.JewelEarth.Infrastructure.Startup.Abstractions;

namespace JewelAddinTraining.Application.Logic
{
    public sealed class Module : IAppModule
    {
        public void Configuration(IAppBuilder builder)
        {
            builder.UseServiceRegistration(x =>
                                           {
                                               x.Register<ICommandHandler<CreatePolylineSetCommand>, CreatePolylineSetCommandHandler>();
                                           });
        }
    }
}