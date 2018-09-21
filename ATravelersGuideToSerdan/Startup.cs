using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ATravelersGuideToSerdan.Startup))]
namespace ATravelersGuideToSerdan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
