using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gittest1.Startup))]
namespace gittest1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
