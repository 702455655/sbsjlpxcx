using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using sbsjlpxcx.App_Start;

namespace sbsjlpxcx
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}