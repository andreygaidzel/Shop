using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Owin;
using Shop.Configuration;
using Shop.WEB.App_Start;

[assembly: OwinStartup(typeof(Shop.WEB.Startup))]
namespace Shop.WEB
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

            var container = InjectionConfig.Configure();

            MappingConfig.Register();
        }
    }
}