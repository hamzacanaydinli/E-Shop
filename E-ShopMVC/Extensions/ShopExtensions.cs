using E_Shop.BL.Menagers.Abstract;
using E_Shop.BL.Menagers.Concrete;

namespace E_ShopMVC.Extensions
{
    public static class ShopExtensions
    {
        public static IServiceCollection AddShopServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IManager<>), typeof(Manager<>));

            return services;
        }
    }
}
