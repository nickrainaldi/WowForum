using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WowForum.Startup))]
namespace WowForum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
