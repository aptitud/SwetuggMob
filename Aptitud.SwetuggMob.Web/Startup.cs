﻿using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

public class Startup
{
    public void Configuration(IAppBuilder app)
    {
        app.UseNancy();
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
    }
}

