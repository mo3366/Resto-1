using Resto.BLL.Service.Abstraction;
using Resto.BLL.Service.Impelementation;
using Resto.DAL.Repo.Abstraction;
using Resto.DAL.Repo.Impelementation;

namespace Resto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IBookingRepo, BookingRepo>();
            builder.Services.AddScoped<IBookingService, BookingService>();
            builder.Services.AddScoped<ITableRepo, TableRepo>();
            builder.Services.AddScoped<ITableService, TableService>();
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
