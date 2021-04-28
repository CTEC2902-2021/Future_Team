using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FootballClub.Startup))]
namespace FootballClub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
