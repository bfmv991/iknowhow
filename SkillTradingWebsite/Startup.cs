using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkillTradingWebsite.Startup))]
namespace SkillTradingWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
