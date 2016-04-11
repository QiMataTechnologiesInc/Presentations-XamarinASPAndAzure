using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QiMata.Presentation.Web.Startup))]
namespace QiMata.Presentation.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
