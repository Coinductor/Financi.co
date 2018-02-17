using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Financi.co.Startup))]
namespace Financi.co
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
