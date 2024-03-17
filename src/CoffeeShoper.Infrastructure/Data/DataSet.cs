using CoffeeShoper.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeShoper.Infrastructure.Data;

public class DataSet
{
    public static void IncludeData(IServiceProvider serviceProvider)
    {
        using (var context = serviceProvider.GetRequiredService<ApplicationDbContext>())
        {
            Console.WriteLine("Applying migrations...");
            context.Database.Migrate();

            if (!context.CoffeeShops.Any())
            {
                Console.WriteLine("Creating initial data...");
                context.CoffeeShops.Add(new CoffeeShop() { Name = "Teste", OpeningHours = "Teste", Address = "Teste" });
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Database already contains data...");
            }

        }
    }
}