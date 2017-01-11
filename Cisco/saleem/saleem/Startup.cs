using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(saleem.Startup))]
namespace saleem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
