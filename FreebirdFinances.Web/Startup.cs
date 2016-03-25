using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FreebirdFinances.Web.Startup))]
namespace FreebirdFinances.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
