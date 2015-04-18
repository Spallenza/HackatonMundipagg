using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using Dlp.Framework.Container;
using Hackaton.Core.Utility;

[assembly: OwinStartup(typeof(Hackaton.Startup))]

namespace Hackaton
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            IocFactory.Register(
                Component.For<IConfigurationUtility>().ImplementedBy<ConfigurationUtility>());
        
        }
    }
}
