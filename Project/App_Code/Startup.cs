using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Trios.Startup))]
namespace Trios
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
