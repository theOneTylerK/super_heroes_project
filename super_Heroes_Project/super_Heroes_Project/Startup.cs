using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(super_Heroes_Project.Startup))]
namespace super_Heroes_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
