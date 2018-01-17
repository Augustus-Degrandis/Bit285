using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A01.Startup))]
namespace A01
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
