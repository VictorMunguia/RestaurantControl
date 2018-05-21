using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantControl.Startup))]
namespace RestaurantControl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
