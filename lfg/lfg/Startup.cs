using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lfg.Startup))]
namespace lfg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
