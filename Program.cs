using CreditManagementSystemApp.Data;
using CreditManagementSystemApp.Models;
using CreditManagementSystemApp.Profiles;
using CreditManagementSystemApp.Repositories.Implementations;
using CreditManagementSystemApp.Repositories.Interfaces;
using CreditManagementSystemApp.Services.Implementations;
using CreditManagementSystemApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CreditManagementSystemApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.  
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            builder.Services.AddScoped<IMerchantRepository, MerchantRepository<Merchant>>();
            builder.Services.AddScoped<IMerchantService, MerchantService>();

            builder.Services.AddScoped<IBranchRepository, BranchRepository<Branch>>();
            builder.Services.AddScoped<IBranchService, BranchService>();

            builder.Services.AddAutoMapper(typeof(CustomProfile).Assembly);

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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
