using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Saleem.Startup))]
namespace Saleem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
