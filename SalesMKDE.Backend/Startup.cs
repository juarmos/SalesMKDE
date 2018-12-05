using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesMKDE.Backend.Startup))]
namespace SalesMKDE.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
