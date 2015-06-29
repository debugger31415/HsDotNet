using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hsDotNet.Startup))]
namespace hsDotNet
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
