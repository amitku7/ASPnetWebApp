using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPnetWebApp.Startup23))]
namespace ASPnetWebApp
{
    public partial class Startup23
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
