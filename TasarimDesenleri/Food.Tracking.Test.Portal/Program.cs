using Food.Tracking.DataAccess.Concrete.Context;
using Food.Tracking.Test.Portal.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Food.Tracking.Test.Portal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //DbContext V1
            builder.Services.AddScoped<FoodDbContext>();

            //DbContext V2
            //builder.Services.AddDbContext<FoodV2DbContext>(x =>
            //    x.UseSqlServer(
            //        "Data Source = DEVOPS\\DEVOPS; Initial Catalog = FoodTrackingV2; Integrated Security = True;TrustServerCertificate=Yes"));

            //DbContext V3
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json")
            .Build();

            var connectionString = config.GetSection("ConnectionStrings").Value;
            ///var connectionString_arastirma = config.GetConnectionString("ConnectionStrings");
            builder.Services.AddDbContext<FoodV2DbContext>(x =>
                x.UseSqlServer(connectionString));

            //DbContextV4
            //Model kullaılarak yapılacak


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}