using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nigh.Startup))]
namespace Nigh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
