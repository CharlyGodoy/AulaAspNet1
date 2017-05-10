using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Calculadora.Startup))]
namespace Calculadora
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
