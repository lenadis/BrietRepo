using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Briet.Startup))]
namespace Briet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
