using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MugShareWebApp.Startup))]
namespace MugShareWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
