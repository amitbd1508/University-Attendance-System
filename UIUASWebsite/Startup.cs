using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UIUASWebsite.Startup))]
namespace UIUASWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
