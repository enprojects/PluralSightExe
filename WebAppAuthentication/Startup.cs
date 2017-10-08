using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppAuthentication.Startup))]
namespace WebAppAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
