using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopDienThoai.Startup))]
namespace ShopDienThoai
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
