using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CordingTraning_from20190221.Startup))]
namespace CordingTraning_from20190221
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
