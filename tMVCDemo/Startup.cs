using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tMVCDemo.Startup))]
namespace tMVCDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
