using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingHtml.Startup))]
namespace TestingHtml
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
