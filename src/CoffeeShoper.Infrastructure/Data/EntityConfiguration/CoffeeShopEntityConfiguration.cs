using CoffeeShoper.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShoper.Infrastructure.Data.EntityConfiguration;

public class CoffeeShopEntityConfiguration : IEntityTypeConfiguration<CoffeeShop>
{
    public void Configure(EntityTypeBuilder<CoffeeShop> builder)
    {
        builder.HasKey(c => c.CoffeeShopId);
        builder.Property(c => c.Name);
        builder.Property(c => c.OpeningHours);
        builder.Property(c => c.Address);
    }
}