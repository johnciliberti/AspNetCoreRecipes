using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForms.Web.Startup))]
namespace WebForms.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
