using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspMVCDatabaseFirstWithIdentity.Startup))]
namespace AspMVCDatabaseFirstWithIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
