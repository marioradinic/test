using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testtfs.Startup))]
namespace testtfs
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
