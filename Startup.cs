using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sd207417MIS4200.Startup))]
namespace sd207417MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
