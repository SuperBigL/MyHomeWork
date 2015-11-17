using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HWSite.Startup))]
namespace HWSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
