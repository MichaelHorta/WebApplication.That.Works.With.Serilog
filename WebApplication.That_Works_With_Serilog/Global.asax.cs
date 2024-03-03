using Serilog;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplication.That_Works_With_Serilog
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            BuildLogging();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void BuildLogging()
        {
            LoggerConfiguration loggerConfiguration = new LoggerConfiguration();
            loggerConfiguration.ReadFrom.AppSettings();
            Serilog.Core.Logger logger = loggerConfiguration.CreateLogger();
            Log.Logger = logger;
        }
    }
}
