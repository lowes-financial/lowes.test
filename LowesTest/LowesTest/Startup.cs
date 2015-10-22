using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LowesTest.Startup))]
namespace LowesTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
