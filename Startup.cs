using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StayInTouch.Startup))]
namespace StayInTouch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
