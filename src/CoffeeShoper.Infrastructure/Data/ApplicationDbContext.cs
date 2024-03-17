using CoffeeShoper.Domain;
using CoffeeShoper.Infrastructure.Data.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShoper.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CoffeeShopEntityConfiguration());

        base.OnModelCreating(modelBuilder);
    }
    public DbSet<CoffeeShop> CoffeeShops { get; set; }
}