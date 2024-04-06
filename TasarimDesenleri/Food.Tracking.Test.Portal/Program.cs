using Food.Tracking.BusinessLogic.MusteriTuruGrubu;
using Food.Tracking.Context.ContextSettings;
using Food.Tracking.DataAccess.Repository;
using Food.Tracking.Entities;
using Food.Tracking.Model;
using Food.Tracking.Test.Portal.Container;
using Food.Tracking.Test.Portal.DataAccess;
using Microsoft.EntityFrameworkCore;

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
            builder.Services.AddScoped<IMusteriTuruGrubuRepository, MusteriTuruGrubuRepository>();
            builder.Services.AddScoped<IMusteriTuruGrubuBL, MusteriTuruGrubuBL>();

            //builder.Services.BusinessLogicInstall();

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
            
            builder.Services.AddDbContext<FoodV2DbContext>(x =>
                x.UseSqlServer(connectionString));


            //DbContextV4
            //Model kullaılarak yapılacak
            var appSettings = config.GetSection("ConnectionStrings").Get<AppSettings>();
            builder.Services.AddDbContext<FoodV2DbContext>(x =>
                x.UseSqlServer(appSettings.DbConnectionString));


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
                //pattern: "{controller=Home}/{action=Index}/{id?}");
                pattern: "{controller=MusteriTuruGrubu}/{action=Index}/{id?}");
                

            app.Run();
        }
    }
}