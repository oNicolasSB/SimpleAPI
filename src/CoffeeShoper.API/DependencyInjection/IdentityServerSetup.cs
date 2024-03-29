namespace CoffeeShoper.API.DependencyInjection;

public static class IdentityServerSetup
{
    public static void ConfigureIdentityServer(this IServiceCollection services, IConfiguration configuration)
    {
        string connectionIdentity = configuration.GetValue<string>("IdentityServerUrl");
        string clientId = configuration.GetValue<string>("IdentityServerClientId");

        services.AddAuthentication("Bearer")
            .AddIdentityServerAuthentication("Bearer", options =>
            {
                options.Authority = connectionIdentity;
                options.ApiName = clientId;
            });
    }
}