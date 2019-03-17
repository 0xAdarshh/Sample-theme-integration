using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sophub.Startup))]
namespace sophub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
