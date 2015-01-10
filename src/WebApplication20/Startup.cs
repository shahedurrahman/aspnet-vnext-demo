using Microsoft.AspNet.Builder;

namespace WebApplication20
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseWelcomePage();
        }
    }
}