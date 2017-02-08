using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo_for_Git.Startup))]
namespace Demo_for_Git
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
