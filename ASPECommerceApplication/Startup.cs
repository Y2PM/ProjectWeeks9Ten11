using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPECommerceApplication.Startup))]
namespace ASPECommerceApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
