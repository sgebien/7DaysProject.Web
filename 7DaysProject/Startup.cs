﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_7DaysProject.Startup))]
namespace _7DaysProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
        // here is my change
        // and here is my new change
    }
}
