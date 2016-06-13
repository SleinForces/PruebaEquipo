using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaEquipo.Startup))]
namespace PruebaEquipo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
