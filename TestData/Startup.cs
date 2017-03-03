using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestData.Startup))]
namespace TestData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
