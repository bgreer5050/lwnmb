﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LWNMBSite2.Startup))]
namespace LWNMBSite2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
