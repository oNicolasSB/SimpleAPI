using CoffeeShoper.Domain;
using CoffeeShoper.Infrastructure.Data;
using CoffeeShoper.Infrastructure.Data.Repositories;

namespace CoffeeShoper.API.DependencyInjection;

public static class RepositoryConfiguration
{
    public static void ConfigureRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
    }
}