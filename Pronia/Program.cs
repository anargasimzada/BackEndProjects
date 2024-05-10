using Microsoft.EntityFrameworkCore;
using Pronia.DataAccessLayer;

namespace Pronia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ProniaContext>();
            var app = builder.Build();

            app.MapControllerRoute(name: "areas",pattern: "{area:exists}/{controller=Slider}/{action=Index}/{id?}");
            app.UseStaticFiles();
            app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
