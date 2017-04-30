using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VisualAnalyticsProject.Startup))]
namespace VisualAnalyticsProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
