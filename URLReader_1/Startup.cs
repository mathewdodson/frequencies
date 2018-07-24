using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(URLReader_1.Startup))]
namespace URLReader_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
