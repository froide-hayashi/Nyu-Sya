using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nyu_Sya.Startup))]
namespace Nyu_Sya
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
