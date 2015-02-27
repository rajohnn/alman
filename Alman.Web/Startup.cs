using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Alman.Web.Startup))]
namespace Alman.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
