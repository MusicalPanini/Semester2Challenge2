using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(S2C1.Startup))]
namespace S2C1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
