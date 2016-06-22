using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RomanNumerals.Startup))]
namespace RomanNumerals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
