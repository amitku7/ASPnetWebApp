using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPnetWebApp.Facebook))]
namespace ASPnetWebApp
{
    public partial class Facebook
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}