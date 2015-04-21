using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaEgressosMapa.Startup))]
namespace SistemaEgressosMapa
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
