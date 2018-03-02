using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDev3.CentiSoft.Web.FrontEnd.Startup))]
namespace WebDev3.CentiSoft.Web.FrontEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
