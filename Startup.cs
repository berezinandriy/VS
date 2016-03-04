using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Debugging.Startup))]
namespace Debugging
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
