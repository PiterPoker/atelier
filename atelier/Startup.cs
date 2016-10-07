using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(atelier.Startup))]
namespace atelier
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
