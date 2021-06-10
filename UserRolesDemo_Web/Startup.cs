using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserRolesDemo_Web.Startup))]
namespace UserRolesDemo_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
