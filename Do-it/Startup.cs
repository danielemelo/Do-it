using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Do_it.Startup))]
namespace Do_it
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
