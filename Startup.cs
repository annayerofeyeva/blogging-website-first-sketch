﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BloggingWebsiteV1._0.Startup))]
namespace BloggingWebsiteV1._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
