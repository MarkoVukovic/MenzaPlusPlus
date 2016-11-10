using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MenzaPlusPlus.Startup))]
namespace MenzaPlusPlus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
