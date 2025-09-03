using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderProductService.Domain.Entities.Orders;

namespace OrderProductService.Infrastructure.OrdersPersistence;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        ConfigureOrderTable(builder);
    }

    private void ConfigureOrderTable(EntityTypeBuilder<Order> builder)
    {
        builder
            .ToTable("orders");

        builder
            .HasKey(x => x.Id);

        builder
            .Property(x => x.Id)
            .ValueGeneratedNever();

        builder
            .Property(x => x.CustomerName)
            .IsRequired();

        builder
            .Property(x => x.Address)
            .IsRequired();

        builder
            .Property(x => x.OrderDate)
            .IsRequired();

        builder
            .Property(x => x.Status)
            .IsRequired();
    }
}