using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(ProductManagement.MVC.Areas.Identity.IdentityHostingStartup))]
namespace ProductManagement.MVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}