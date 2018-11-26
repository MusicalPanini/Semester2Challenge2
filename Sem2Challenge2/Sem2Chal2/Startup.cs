using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sem2Chal2.Startup))]
namespace Sem2Chal2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
