using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DFEJobs.Startup))]
namespace DFEJobs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
