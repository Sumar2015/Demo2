using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(demoLog.Startup))]
namespace demoLog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
