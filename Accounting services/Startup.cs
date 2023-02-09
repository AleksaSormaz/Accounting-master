using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Accounting_services.Startup))]
namespace Accounting_services
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
