using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamenParcial3.Startup))]
namespace ExamenParcial3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
