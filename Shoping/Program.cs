using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shoping.Data;
using Shoping.MappingsProfiles;
using Shoping.Repositories;

namespace Shoping
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ShopingContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("ShopingContext") ?? throw new InvalidOperationException("Connection string 'ShopingContext' not found.")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            // builder.Services.AddAutoMapper(typeof(ShopingProfile));
            builder.Services.AddScoped<IRegionRepository, SQLRegionRepository>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
