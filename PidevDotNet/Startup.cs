using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PidevDotNet.Startup))]
namespace PidevDotNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
