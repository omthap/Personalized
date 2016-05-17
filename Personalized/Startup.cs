using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Personalized.Startup))]
namespace Personalized
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
