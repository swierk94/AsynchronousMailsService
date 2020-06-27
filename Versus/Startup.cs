using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Versus.Startup))]
namespace Versus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
