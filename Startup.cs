using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Moviea.Startup))]
namespace Moviea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
