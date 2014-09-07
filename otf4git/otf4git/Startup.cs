using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(otf4git.Startup))]
namespace otf4git
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
