using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eRecycle.Startup))]
namespace eRecycle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
