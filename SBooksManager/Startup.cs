using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SBooksManager.Startup))]
namespace SBooksManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
