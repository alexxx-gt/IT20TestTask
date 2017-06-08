using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IT20TestTaskAuth.Startup))]
namespace IT20TestTaskAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
