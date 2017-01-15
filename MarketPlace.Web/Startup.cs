using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarketPlace.Web.Startup))]
namespace MarketPlace.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
