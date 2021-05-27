using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZenithLanka.Startup))]
namespace ZenithLanka
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
