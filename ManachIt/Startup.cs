using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManachIt.Startup))]
namespace ManachIt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
