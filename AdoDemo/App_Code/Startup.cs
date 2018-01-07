using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdoDemo.Startup))]
namespace AdoDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
