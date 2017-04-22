using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ForestManager.Startup))]
namespace ForestManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
