using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mapp.Startup))]
namespace Mapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
