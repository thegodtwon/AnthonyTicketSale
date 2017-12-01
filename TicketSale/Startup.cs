using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TicketSale.Startup))]
namespace TicketSale
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
