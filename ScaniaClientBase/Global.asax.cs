using ScaniaClientBase.Models;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ScaniaClientBase
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // SSBCVP : Se você alterar algo no modelo a aplicação irá dropar e recriar o seu banco
            Database.SetInitializer<ClienteContext>(new DropCreateDatabaseIfModelChanges<ClienteContext>());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}