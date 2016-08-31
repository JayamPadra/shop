using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopCham.Startup))]
namespace ShopCham
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
