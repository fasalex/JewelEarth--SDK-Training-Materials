﻿using Joa.JewelEarth.Infrastructure.Startup.Abstractions;
using Joa.JewelEarth.Basics;


namespace JewelAddinTraining.Logic.Addin
{
    public sealed class Plugin : PluginBase, IAppModule
    {
        public void Configuration(IAppBuilder builder)
        {
            builder.UseModuleRegistration(r =>
            {
                r.Register<Domain.Core.Module>();
                r.Register<Domain.Logic.Module>();
                r.Register<Application.Core.Module>();
                r.Register<Application.Logic.Module>();
            });
        }
    }
}