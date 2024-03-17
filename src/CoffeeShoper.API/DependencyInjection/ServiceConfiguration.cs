using CoffeeShoper.Interfaces;
using CoffeeShoper.Services;

namespace CoffeeShoper.API.DependencyInjection;

public static class ServiceConfiguration
{
    public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ICoffeeShopService, CoffeeShopService>();
    }
}