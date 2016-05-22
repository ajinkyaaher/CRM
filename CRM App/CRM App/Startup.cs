using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRM_App.Startup))]
namespace CRM_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
