using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CocktailMVC.Startup))]
namespace CocktailMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
