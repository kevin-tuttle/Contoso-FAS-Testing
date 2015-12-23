using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Contoso_FAS_Web.Startup))]
namespace Contoso_FAS_Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
