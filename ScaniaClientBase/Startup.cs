using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScaniaClientBase.Startup))]
namespace ScaniaClientBase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
