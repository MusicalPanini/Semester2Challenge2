using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sem2Challenge2.Startup))]
namespace Sem2Challenge2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
