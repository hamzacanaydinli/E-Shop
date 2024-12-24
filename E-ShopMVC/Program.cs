using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using E_Shop.Entities.DbContexts;
using E_ShopMVC.Extensions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

namespace E_ShopMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            #region DbContext Registiration
            var constr = builder.Configuration.GetConnectionString("E-Shop");
            builder.Services.AddDbContext<SqlDbContext>(options => options.UseSqlServer(constr));
            #endregion

            #region Notify Service Configuration
            builder.Services.AddNotyf(p =>
            {
                p.Position = NotyfPosition.BottomRight;
                p.DurationInSeconds = 7;
                p.IsDismissable = true;
            });
            #endregion

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.Cookie.Name = "E-Shop";
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/ErisimHatasi";
                options.Cookie.HttpOnly = true; //Tarayicidaki diğer scriptler okuyamasin diye güvenlik 
                options.Cookie.SameSite = SameSiteMode.Strict; //Başka tarayicilar tarafindan ulaşilamasin diye güvenlik önlemi
                options.ExpireTimeSpan = TimeSpan.FromMinutes(10); //
                options.SlidingExpiration = true; //Herhangi sitede bir hareket olduğunda süreyi 10 dk uzatir

            });

            builder.Services.AddShopServices();

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
            app.UseNotyf();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
