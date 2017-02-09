using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using Rently.App_Start;

namespace Rently
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //used for automapper c(configuration) 
            Mapper.Initialize(c => c.AddProfile<MappingProfile>());
            //used for the api 
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
