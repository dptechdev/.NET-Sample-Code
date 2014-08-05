using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormMessAround.Startup))]
namespace WebFormMessAround
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
