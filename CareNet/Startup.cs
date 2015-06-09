using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CareNet.Startup))]
namespace CareNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
